"""
BeamPy — физическая симуляция разрушения BeamNG-модели.
Запуск напрямую: python physics.py
или через main.py → пункт 2.

Что делает:
- Читает .jbeam файл через beam_parser
- Строит сетку нод (точек массы) и балок (пружин)
- Симулирует гравитацию, упругость, демпфирование
- Рвёт балки при силе > beamStrength
- Деформирует балки при силе > beamDeform
- Визуализирует всё в 3D через VPython
"""
from pathlib import Path

import numpy as np
from vpython import (
    vector, sphere, cylinder, color, rate, scene, box, label,
)

from beam_parser import extract_nodes_beams

# ============================================================
# НАСТРОЙКИ
# ============================================================
JBEAM_PATH = Path(__file__).parent / "lexus_is300" / "lexus_is300_bumper_F.jbeam"
GRAVITY = np.array([0.0, -9.81, 0.0])
DT = 1.0 / 120.0
SCALE = 5.0
DAMPING = 0.999


# ============================================================
# ФИЗИЧЕСКОЕ СОСТОЯНИЕ
# ============================================================
class Node:
    def __init__(self, nid, pos, mass):
        self.id = nid
        self.pos = np.array(pos, dtype=float)
        self.vel = np.zeros(3)
        self.force = np.zeros(3)
        self.mass = mass


class Beam:
    def __init__(self, a: Node, b: Node, rest_length, spring, damp, deform, strength):
        self.a = a
        self.b = b
        self.rest_length = rest_length
        self.spring = spring
        self.damp = damp
        self.deform = deform
        self.strength = strength
        self.broken = False

    def update(self, dt):
        if self.broken:
            return
        delta = self.b.pos - self.a.pos
        length = float(np.linalg.norm(delta))
        if length < 1e-9:
            return
        direction = delta / length
        extension = length - self.rest_length
        f_spring = self.spring * extension
        rel_vel = np.dot(self.b.vel - self.a.vel, direction)
        f_damp = self.damp * rel_vel
        total_force = f_spring + f_damp

        if abs(total_force) > self.strength:
            self.broken = True
            return
        if abs(total_force) > self.deform:
            self.rest_length = length

        force_vec = direction * total_force
        self.a.force += force_vec
        self.b.force -= force_vec


# ============================================================
# ВИЗУАЛИЗАЦИЯ
# ============================================================
def make_visual(nodes: dict, beams: list, offset_center: np.array):
    vis_nodes = {}
    for nid, n in nodes.items():
        p = (n.pos - offset_center) * SCALE
        vis_nodes[nid] = sphere(pos=vector(*p), radius=0.05, color=color.cyan)

    vis_beams = []
    for beam in beams:
        a = vis_nodes[beam.a.id].pos
        b = vis_nodes[beam.b.id].pos
        vis_beams.append(cylinder(pos=a, axis=b - a, radius=0.015, color=color.white))
    return vis_nodes, vis_beams


def update_visual(nodes: dict, beams: list, vis_nodes, vis_beams, offset_center):
    for nid, n in nodes.items():
        p = (n.pos - offset_center) * SCALE
        vis_nodes[nid].pos = vector(*p)
    for beam, cyl in zip(beams, vis_beams):
        if beam.broken:
            cyl.visible = False
            continue
        a = vis_nodes[beam.a.id].pos
        b = vis_nodes[beam.b.id].pos
        cyl.pos = a
        cyl.axis = b - a
        stress = abs(np.linalg.norm(beam.b.pos - beam.a.pos) - beam.rest_length) * beam.spring
        if stress > beam.strength * 0.8:
            cyl.color = color.red
        elif stress > beam.deform * 0.8:
            cyl.color = color.yellow
        else:
            cyl.color = color.white


# ============================================================
# ГЛАВНЫЙ ЦИКЛ
# ============================================================
def main():
    if not JBEAM_PATH.exists():
        print(f"❌ Файл не найден: {JBEAM_PATH}")
        return

    raw_nodes, raw_beams = extract_nodes_beams(JBEAM_PATH)

    nodes = {nid: Node(nid, info["pos"], info["mass"]) for nid, info in raw_nodes.items()}
    beams = [
        Beam(nodes[b["a"]], nodes[b["b"]],
             b["rest_length"], b["spring"], b["damp"], b["deform"], b["strength"])
        for b in raw_beams
    ]

    all_pos = np.array([n.pos for n in nodes.values()])
    center = all_pos.mean(axis=0)

    scene.title = "BeamPy — Physics Destruction"
    scene.background = color.black
    scene.center = vector(0, 0, 0)
    scene.range = 5

    box(pos=vector(0, -3, 0), size=vector(20, 0.1, 20), color=color.gray(0.4))

    # начальная скорость вниз (имитация удара)
    for n in nodes.values():
        n.vel = np.array([0.0, -20.0, 0.0])

    vis_nodes, vis_beams = make_visual(nodes, beams, center)
    hud = label(pos=vector(0, 6, 0), text="BeamPy — запуск", color=color.white, height=20)

    t = 0.0
    frame = 0
    while True:
        rate(1.0 / DT)
        for n in nodes.values():
            n.force[:] = 0.0
            n.force += n.mass * GRAVITY

        for beam in beams:
            beam.update(DT)

        ground_y = -3.0 / SCALE + center[1]
        for n in nodes.values():
            acc = n.force / n.mass
            n.vel = (n.vel + acc * DT) * DAMPING
            n.pos += n.vel * DT
            if n.pos[1] < ground_y:
                n.pos[1] = ground_y
                if n.vel[1] < 0:
                    n.vel[1] = -n.vel[1] * 0.2
                    n.vel[0] *= 0.8
                    n.vel[2] *= 0.8

        update_visual(nodes, beams, vis_nodes, vis_beams, center)

        t += DT
        frame += 1
        if frame % 10 == 0:
            broken = sum(1 for b in beams if b.broken)
            hud.text = (
                f"t = {t:.1f} c   |   разорвано: {broken}/{len(beams)}   |   "
                f"нод: {len(nodes)}"
            )


if __name__ == "__main__":
    main()
