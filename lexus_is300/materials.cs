
singleton Material(fullsize)
{
   mapTo = "fullsize";
   //diffuseMap[3] = "vehicles/fullsize/fullsize_police.dds";
   //specularMap[3] = "vehicles/fullsize/fullsize_s.dds";
   //normalMap[3] = "vehicles/fullsize/fullsize_n.dds";
   diffuseMap[2] = "vehicles/altezza/fullsize_c_alt.dds";
   specularMap[2] = "vehicles/altezza/fullsize_s.dds";
   normalMap[2] = "vehicles/altezza/fullsize_n.dds";
   diffuseMap[1] = "vehicles/altezza/fullsize_d.dds";
   specularMap[1] = "vehicles/altezza/fullsize_s.dds";
   normalMap[1] = "vehicles/altezza/fullsize_n.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   specularMap[0] = "vehicles/common/null.dds";
   normalMap[0] = "vehicles/altezza/fullsize_n.dds";
   //diffuseMap[3] = "vehicles/fullsize/fullsize_dirt.dds";
   //normalMap[3] = "vehicles/fullsize/fullsize_n.dds";
   specularPower[0] = "16";
   pixelSpecular[0] = "1";
   specularPower[1] = "16";
   pixelSpecular[1] = "1";
   diffuseColor[0] = "1 1 1 1";
   diffuseColor[1] = "1 1 1 1";
   diffuseColor[2] = "1 1 1 1";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   useAnisotropic[2] = "1";
   //diffuseColor[3] = "0 0.3 0.9 1";
   //diffuseColor[3] = "1.5 1.5 1.5 1";
   castShadows = "1";
   translucent = "1";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "0";
   cubemap = "BNG_Sky_02_cubemap";
   beamngDiffuseColorSlot = 2;
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(fullsize_gauges)
{
   mapTo = "fullsize_gauges";
   diffuseMap[0] = "fullsize_gauges_d.dds";
   specularMap[0] = "fullsize_gauges_s.dds";
   normalMap[0] = "fullsize_gauges_n.dds";
   specularPower[0] = "16";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
   diffuseColor[0] = "0.75 0.75 0.75 1";
};

singleton Material(fullsize_gauges_on)
{
   mapTo = "fullsize_gauges_on";
   diffuseMap[1] = "fullsize_gauges_d.dds";
   specularMap[1] = "fullsize_gauges_s.dds";
   normalMap[1] = "fullsize_gauges_n.dds";
   diffuseMap[0] = "fullsize_gauges_d.dds";
   specularMap[0] = "fullsize_gauges_s.dds";
   normalMap[0] = "fullsize_gauges_n.dds";
   specularPower[0] = "16";
   pixelSpecular[0] = "1";
   glow[1] = "1";
   emissive[1] = "1";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
   diffuseColor[0] = "0.75 0.75 0.75 1";
   diffuseColor[1] = "1.5 1.5 1.5 0.2";
};

singleton Material(fullsize_interior)
{
   mapTo = "fullsize_interior";
   diffuseMap[0] = "fullsize_interior_d.dds";
   normalMap[0] = "fullsize_interior_n.dds";
   specularPower[0] = "16";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   specularMap[0] = "fullsize_interior_s.dds";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
   diffuseColor[0] = "0.8 0.8 0.8 1";
};

singleton Material(fullsize_glass)
{
   mapTo = "fullsize_glass";
   diffuseMap[0] = "vehicles/altezza/fullsize_glass_d.dds";
   specularMap[0] = "vehicles/altezza/fullsize_glass_s.dds";
   diffuseMap[1] = "vehicles/altezza/fullsize_glass_da.dds";
   specularMap[1] = "vehicles/altezza/fullsize_glass_s.dds";
   //diffuseMap[2] = "vehicles/fullsize/fullsize_glass_dirt.dds";
   specularPower[0] = "128";
   pixelSpecular[0] = "1";
   specularPower[1] = "128";
   pixelSpecular[1] = "1";
   diffuseColor[0] = "1 1 1 1";
   diffuseColor[1] = "1 1 1 1";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   //diffuseColor[2] = "1.5 1.5 1.5 1";
   castShadows = "0";
   translucent = "1";
   alphaTest = "1";
   alphaRef = "0";
   cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(fullsize_signal_L)
{
   mapTo = "fullsize_signal_L";
};

singleton Material(fullsize_signal_R)
{
   mapTo = "fullsize_signal_R";
};

singleton Material(fullsize_taillight)
{
   mapTo = "fullsize_taillight";
};

singleton Material(fullsize_chmsl)
{
   mapTo = "fullsize_chmsl";
};

singleton Material(fullsize_headlight)
{
   mapTo = "fullsize_headlight";
};

singleton Material(fullsize_reverselight)
{
   mapTo = "fullsize_reverselight";
};

singleton Material(fullsize_parkinglight)
{
   mapTo = "fullsize_parkinglight";
};

singleton Material(fullsize_lights_on)
{
   mapTo = "fullsize_lights_on";
   diffuseMap[2] = "vehicles/altezza/fullsize_lights_g.dds";
   specularMap[2] = "vehicles/altezza/fullsize_lights_s.dds";
   normalMap[2] = "vehicles/altezza/fullsize_lights_n.dds";
   diffuseMap[1] = "vehicles/altezza/fullsize_lights_d.dds";
   specularMap[1] = "vehicles/altezza/fullsize_lights_s.dds";
   normalMap[1] = "vehicles/altezza/fullsize_lights_n.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   specularMap[0] = "vehicles/common/null.dds";
   normalMap[0] = "vehicles/altezza/fullsize_lights_n.dds";
   //diffuseMap[3] = "vehicles/fullsize/fullsize_lights_dirt.dds";
   //normalMap[3] = "vehicles/fullsize/fullsize_lights_n.dds";
   specularPower[0] = "16";
   pixelSpecular[0] = "1";
   specularPower[1] = "16";
   pixelSpecular[1] = "1";
   diffuseColor[0] = "1 1 1 1";
   diffuseColor[1] = "1.5 1.5 1.5 1";
   diffuseColor[2] = "1.5 1.5 1.5 0.12";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   useAnisotropic[2] = "1";
   //diffuseColor[3] = "1.5 1.5 1.5 1";
   castShadows = "1";
   translucent = "1";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "0";
   cubemap = "BNG_Sky_02_cubemap";
   glow[2] = "1";
   emissive[2] = "1";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(fullsize_lights_on_intense)
{
   mapTo = "fullsize_lights_on_intense";
   diffuseMap[2] = "vehicles/altezza/fullsize_lights_g.dds";
   specularMap[2] = "vehicles/altezza/fullsize_lights_s.dds";
   normalMap[2] = "vehicles/altezza/fullsize_lights_n.dds";
   diffuseMap[1] = "vehicles/altezza/fullsize_lights_d.dds";
   specularMap[1] = "vehicles/altezza/fullsize_lights_s.dds";
   normalMap[1] = "vehicles/altezza/fullsize_lights_n.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   specularMap[0] = "vehicles/common/null.dds";
   normalMap[0] = "vehicles/altezza/fullsize_lights_n.dds";
   //diffuseMap[3] = "vehicles/fullsize/fullsize_lights_dirt.dds";
   //normalMap[3] = "vehicles/fullsize/fullsize_lights_n.dds";
   specularPower[0] = "16";
   pixelSpecular[0] = "1";
   specularPower[1] = "16";
   pixelSpecular[1] = "1";
   diffuseColor[0] = "1 1 1 1";
   diffuseColor[1] = "1.5 1.5 1.5 1";
   diffuseColor[2] = "1.5 1.5 1.5 0.20";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   useAnisotropic[2] = "1";
   //diffuseColor[3] = "1.5 1.5 1.5 1";
   castShadows = "1";
   translucent = "1";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "0";
   cubemap = "BNG_Sky_02_cubemap";
   glow[2] = "1";
   emissive[2] = "1";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(fullsize_glass_dmg)
{
   mapTo = "fullsize_glass_dmg";
   diffuseMap[0] = "vehicles/altezza/fullsize_glass_dmg_d.dds";
   specularMap[0] = "vehicles/common/glass_dmg_s.dds";
   normalMap[0] = "vehicles/common/glass_dmg_n.dds";
   //diffuseMap[2] = "vehicles/fullsize/fullsize_glass_dirt.dds";
   specularPower[0] = "32";
   diffuseColor[0] = "1.5 1.5 1.5 1";
   useAnisotropic[0] = "1";
   //diffuseColor[2] = "1.5 1.5 1.5 1";
   castShadows = "0";
   translucent = "1";
   alphaTest = "1";
   alphaRef = "0";
   //cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(fullsize_lights_dmg)
{
   mapTo = "fullsize_lights_dmg";
   diffuseMap[0] = "vehicles/altezza/fullsize_lights_dmg_d.dds";
   diffuseColor[1] = "1.5 1.5 1.5 1";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(fullsize_lights)
{
   mapTo = "fullsize_lights";
   diffuseMap[1] = "vehicles/altezza/fullsize_lights_d.dds";
   specularMap[1] = "vehicles/altezza/fullsize_lights_s.dds";
   normalMap[1] = "vehicles/altezza/fullsize_lights_n.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   specularMap[0] = "vehicles/common/null.dds";
   normalMap[0] = "vehicles/altezza/fullsize_lights_n.dds";
   //diffuseMap[2] = "vehicles/fullsize/fullsize_lights_dirt.dds";
   //normalMap[2] = "vehicles/fullsize/fullsize_lights_n.dds";
   specularPower[0] = "16";
   pixelSpecular[0] = "1";
   specularPower[1] = "16";
   pixelSpecular[1] = "1";
   diffuseColor[0] = "1 1 1 1";
   diffuseColor[1] = "1 1 1 1";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   //diffuseColor[2] = "1.5 1.5 1.5 1";
   castShadows = "1";
   translucent = "1";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "0";
   diffuseColor[1] = "1.5 1.5 1.5 1";
   cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};


singleton Material(altezza_Matte__FF000000__spec_)
{
   mapTo = "Matte__FF000000__spec_";
   diffuseColor[0] = "0.109804 0.109804 0.109804 1";
   specularPower[0] = "81";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   glow[0] = "0";
   doubleSided = "1";
};

singleton Material(altezza_aluminium__env_9_spec_)
{
   mapTo = "aluminium__env_9_spec_";
   diffuseMap[0] = "vehicles/altezza/aluminium";
   specularPower[0] = "128";
   translucentBlendOp = "None";
   useAnisotropic[0] = "1";
   minnaertConstant[0] = "1.3";
   doubleSided = "1";
};

singleton Material(altezza_tire__spec_)
{
   mapTo = "tire__spec_";
   diffuseMap[0] = "vehicles/altezza/tire";
   specular[0] = "0.231373 0.231373 0.231373 1";
   specularPower[0] = "1";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_advan__spec_)
{
   mapTo = "advan__spec_";
   diffuseMap[0] = "vehicles/altezza/advan";
   specular[0] = "0.203922 0.203922 0.203922 1";
   specularPower[0] = "1";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_freio__env_7_spec_)
{
   mapTo = "freio__env_7_spec_";
   diffuseMap[0] = "vehicles/altezza/freio";
   specularPower[0] = "16";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_Matte__FF0024BE__spec_)
{
   mapTo = "Matte__FF0024BE__spec_";
   diffuseColor[0] = "0.501961 0.501961 0.505882 1";
   specularPower[0] = "29";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_dare2__env_4_spec_)
{
   mapTo = "dare2__env_4_spec_";
   diffuseMap[2] = "vehicles/altezza/dare2";
   specularMap[2] = "vehicles/altezza/lega_s.dds";
   normalMap[2] = "vehicles/altezza/lega_n.dds";
   diffuseMap[1] = "vehicles/altezza/lega_d.dds";
   specularMap[1] = "vehicles/altezza/lega_s.dds";
   normalMap[1] = "vehicles/altezza/lega_n.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   specularPower[0] = "5";
   pixelSpecular[0] = "10";
   specularPower[1] = "5";
   pixelSpecular[1] = "10";
   diffuseColor[0] = "0 0 0 1";
   diffuseColor[1] = "1 1 1 1";
   diffuseColor[2] = "0.6 0.6 0.6 0.6";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   useAnisotropic[2] = "1";
   castShadows = "1";
   translucent = "1";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "0";
   cubemap = "BNG_Sky_02_cubemap";
   beamngDiffuseColorSlot = 2;
   materialTag0 = "beamng"; materialTag1 = "vehicle";
   doubleSided = "1";
};

singleton Material(altezza_Matte__FF000000__env_50_spec_)
{
   mapTo = "Matte__FF000000__env_50_spec_";
   diffuseColor[0] = "0.0862745 0.0862745 0.0862745 1";
   specularPower[0] = "21";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_Matte__82050505__env_50_spec_trans_)
{
   mapTo = "Matte__82050505__env_50_spec_trans_";
   diffuseColor[0] = "0.137255 0.203922 0.192157 1";
   specularPower[0] = "14";
   translucentBlendOp = "Add";
   specular[0] = "0.533333 0.533333 0.533333 1";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   translucent = "1";
};

singleton Material(altezza_misc__env_21_spec_trans_)
{
   mapTo = "altezza_misc__env_21_spec_trans_";
   diffuseMap[0] = "vehicles/altezza/altezza_misc";
   specularPower[0] = "1";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_remap__prim_env_9_spec_)
{
   mapTo = "remap__prim_env_9_spec_";
   diffuseMap[0] = "vehicles/altezza/remap";
   diffuseMap[2] = "vehicles/altezza/remap";
   specularMap[2] = "vehicles/altezza/lega_s.dds";
   normalMap[2] = "vehicles/altezza/lega_n.dds";
   diffuseMap[1] = "vehicles/altezza/lega_d.dds";
   specularMap[1] = "vehicles/altezza/lega_s.dds";
   normalMap[1] = "vehicles/altezza/lega_n.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   specularPower[0] = "5";
   pixelSpecular[0] = "10";
   specularPower[1] = "5";
   pixelSpecular[1] = "10";
   diffuseColor[0] = "0 0 0 1";
   diffuseColor[1] = "1 1 1 1";
   diffuseColor[2] = "0.8 0.7 0.7 0.8";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   useAnisotropic[2] = "1";
   castShadows = "1";
   translucent = "1";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "0";
   cubemap = "BNG_Sky_02_cubemap";
   beamngDiffuseColorSlot = 2;
   materialTag0 = "beamng"; materialTag1 = "vehicle";
   doubleSided = "1";
};

singleton Material(altezza_vehiclelights128__env_19_spec_FR_)
{
   mapTo = "vehiclelights128__env_19_spec_FR_";
   diffuseColor[0] = "0.658824 0.662745 0.662745 1";
   specularPower[0] = "128";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   minnaertConstant[0] = "2";
   doubleSided = "1";
};

singleton Material(altezza_Matte__FF000000__env_4_spec_)
{
   mapTo = "Matte__FF000000__env_4_spec_";
   diffuseColor[0] = "0.0705882 0.0705882 0.0705882 1";
   specularPower[0] = "14";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_Matte__FF808080__env_19_spec_)
{
   mapTo = "Matte__FF808080__env_19_spec_";
   diffuseColor[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "128";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   minnaertConstant[0] = "1.3";
   doubleSided = "1";
};

singleton Material(altezza_Matte__78000000__env_50_spec_trans_)
{
   mapTo = "Matte__78000000__env_50_spec_trans_";
   diffuseColor[0] = "0.223529 0.223529 0.223529 1";
   specularPower[0] = "11";
   translucentBlendOp = "Add";
   specular[0] = "0.258824 0.258824 0.258824 1";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   translucent = "1";
   materialTag0 = "Miscellaneous";
};

singleton Material(altezza_misc__env_19_spec_)
{
   mapTo = "altezza_misc__env_19_spec_";
   diffuseMap[0] = "vehicles/altezza/altezza_misc";
   specularPower[0] = "21";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_interior__spec_)
{
   mapTo = "altezza_interior__spec_";
   diffuseMap[0] = "vehicles/altezza/altezza_interior";
   specular[0] = "0.419608 0.419608 0.419608 1";
   specularPower[0] = "1";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_seats__spec_)
{
   mapTo = "altezza_seats__spec_";
   diffuseMap[0] = "vehicles/altezza/altezza_seats";
   specular[0] = "0.85 0.85 0.85 1";
   specularPower[0] = "19";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_by_matheus340__env_9_spec_)
{
   mapTo = "by_matheus340__env_9_spec_";
   diffuseMap[2] = "vehicles/altezza/by-matheus340";
   specularMap[2] = "vehicles/altezza/lega_s.dds";
   normalMap[2] = "vehicles/altezza/lega_n.dds";
   diffuseMap[1] = "vehicles/altezza/lega_d.dds";
   specularMap[1] = "vehicles/altezza/lega_s.dds";
   normalMap[1] = "vehicles/altezza/lega_n.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   specularPower[0] = "5";
   pixelSpecular[0] = "10";
   specularPower[1] = "5";
   pixelSpecular[1] = "10";
   diffuseColor[0] = "0 0 0 1";
   diffuseColor[1] = "1 1 1 1";
   diffuseColor[2] = "0.5 0.5 0.5 0.5";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   useAnisotropic[2] = "1";
   castShadows = "1";
   translucent = "1";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "0";
   cubemap = "BNG_Sky_02_cubemap";
   beamngDiffuseColorSlot = 2;
   materialTag0 = "beamng"; materialTag1 = "vehicle";
   doubleSided = "1";
};

singleton Material(altezza_vehiclelights128__env_19_spec_FL_)
{
   mapTo = "vehiclelights128__env_19_spec_FL_";
   diffuseColor[0] = "0.627451 0.627451 0.623529 1";
   specularPower[0] = "39";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   minnaertConstant[0] = "2";
   doubleSided = "1";
};

singleton Material(altezza_Matte__FF000000)
{
   mapTo = "Matte__FF000000";
   diffuseColor[0] = "0.0784314 0.0784314 0.0784314 1";
   specularPower[0] = "41";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_exh__env_9_spec_)
{
   mapTo = "exh__env_9_spec_";
   diffuseMap[0] = "vehicles/altezza/exh";
   specularPower[0] = "1";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   minnaertConstant[0] = "1.4";
   doubleSided = "1";
};

singleton Material(altezza_engine__spec_)
{
   mapTo = "altezza_engine__spec_";
   diffuseMap[0] = "vehicles/altezza/altezza_engine";
   specularPower[0] = "1";
   translucentBlendOp = "None";
   specular[0] = "0.490196 0.490196 0.490196 1";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_chassis__spec_)
{
   mapTo = "chassis__spec_";
   diffuseMap[0] = "vehicles/altezza/chassis";
   specular[0] = "0.372549 0.372549 0.372549 1";
   specularPower[0] = "21";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_exh__env_8_spec_)
{
   mapTo = "exh__env_8_spec_";
   diffuseMap[0] = "vehicles/altezza/exh";
   specularPower[0] = "34";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_Matte__FFC80000__spec_)
{
   mapTo = "Matte__FFC80000__spec_";
   diffuseColor[0] = "0.78 0 0 1";
   specularPower[0] = "46";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_hks__env_2_spec_)
{
   mapTo = "hks__env_2_spec_";
   diffuseMap[0] = "vehicles/altezza/hks";
   specular[0] = "0.33 0.33 0.33 1";
   specularPower[0] = "19";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   minnaertConstant[0] = "1.2";
   doubleSided = "1";
};

singleton Material(altezza_Matte__A0050505__env_50_spec_trans_)
{
   mapTo = "Matte__A0050505__env_50_spec_trans_";
   diffuseColor[0] = "0.02 0.02 0.02 1";
   specularPower[0] = "128";
   translucentBlendOp = "None";
};

singleton Material(altezza_Matte__FF070707__spec_)
{
   mapTo = "Matte__FF070707__spec_";
   diffuseColor[0] = "0.03 0.03 0.03 1";
   specularPower[0] = "1";
   translucentBlendOp = "None";
   specular[0] = "0.466667 0.466667 0.466667 1";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_dials__spec_)
{
   mapTo = "altezza_dials__spec_";
   diffuseMap[0] = "vehicles/altezza/altezza_dials";
   specularPower[0] = "21";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_grill__spec_)
{
   mapTo = "grill__spec_";
   diffuseMap[0] = "vehicles/altezza/grill";
   specularPower[0] = "26";
   translucentBlendOp = "Add";
   diffuseColor[0] = "0.992157 0.992157 0.992157 1";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaRef = "0";
};

singleton Material(altezza_Matte__FF1D1D1D__spec_)
{
   mapTo = "Matte__FF1D1D1D__spec_";
   diffuseColor[0] = "0.11 0.11 0.11 1";
   specularPower[0] = "54";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_carpet__spec_)
{
   mapTo = "altezza_carpet__spec_";
   diffuseMap[0] = "vehicles/altezza/altezza_carpet";
   specular[0] = "0.85 0.85 0.85 1";
   specularPower[0] = "46";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_reflexo__spec_)
{
   mapTo = "reflexo__spec_";
   diffuseMap[0] = "vehicles/altezza/reflexo";
   specularPower[0] = "44";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_supra_leather__spec_)
{
   mapTo = "supra_leather__spec_";
   diffuseMap[0] = "vehicles/altezza/supra_leather";
   specular[0] = "0.54 0.54 0.54 1";
   specularPower[0] = "19";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_Matte__A0000000__spec_trans_)
{
   mapTo = "Matte__A0000000__spec_trans_";
   diffuseColor[0] = "0.176471 0.176471 0.176471 1";
   specularPower[0] = "94";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
};

singleton Material(altezza_Matte__FF1F1F1F__spec_)
{
   mapTo = "Matte__FF1F1F1F__spec_";
   diffuseColor[0] = "0.12 0.12 0.12 1";
   specular[0] = "0.384314 0.384314 0.384314 1";
   specularPower[0] = "19";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_boot__spec_)
{
   mapTo = "boot__spec_";
   diffuseMap[0] = "vehicles/altezza/boot";
   specular[0] = "0.85 0.85 0.85 1";
   specularPower[0] = "56";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_underbody_j2__spec_)
{
   mapTo = "underbody_j2__spec_";
   diffuseMap[0] = "vehicles/altezza/underbody_j2";
   specularPower[0] = "99";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(altezza_podps)
{
   mapTo = "podps";
   diffuseColor[0] = "0.588 0.588 0.588 1";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "1";
   translucentBlendOp = "None";
};

singleton Material(lexus_is300_Matte__FF000_002)
{
   mapTo = "Matte__FF000_002";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[0] = "vehicles/lexus_is300/erefh/body.png";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[0] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/body.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_ad08_sidewal_002)
{
   mapTo = "ad08_sidewal_002";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/body.png";
   materialTag0 = "Miscellaneous";
   diffuseColor[1] = "0.00392157 0.00392157 0.00392157 1";
};

singleton Material(lexus_is300_Matte__FF232_002)
{
   mapTo = "Matte__FF232_002";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/body.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_rota_tamarc__002)
{
   mapTo = "rota_tamarc__002";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseColor[1] = "0.992157 0.992157 0.992157 0.527";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/body.png";
   cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_advan_bmp__s_002)
{
   mapTo = "advan_bmp__s_002";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/ADVAN.bmp";
   specularMap[1] = "vehicles/lexus_is300/erefh/ADVAN.bmp";
   materialTag0 = "Miscellaneous";
   diffuseColor[1] = "0.00392157 0.00392157 0.00392157 1";
};

singleton Material(lexus_is300_Matte__FF000_004)
{
   mapTo = "Matte__FF000_004";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/body.png";
   materialTag0 = "Miscellaneous";
   diffuseColor[1] = "1 1 1 1";
};

singleton Material(lexus_is300_Matte__FFFF3_004)
{
   mapTo = "Matte__FFFF3_004";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/body.png";
   materialTag0 = "Miscellaneous";
   diffuseColor[1] = "1 0 0.0235294 1";
};

singleton Material(lexus_is300_lights__env__007)
{
   mapTo = "lights__env__007";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/lights.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/lights.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_lights__env__008)
{
   mapTo = "lights__env__008";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/lights.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/lights.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_body__prim_e_005)
{
   mapTo = "body__prim_e_005";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/body.png";
   materialTag0 = "Miscellaneous";
   diffuseColor[1] = "0.721569 0.721569 0.721569 0.693";
   cubemap = "BNG_Sky_02_cubemap";
};

singleton Material(lexus_is300_Matte__FFB9F_004)
{
   mapTo = "Matte__FFB9F_004";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseColor[1] = "1 0 0.0235294 1";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/body.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_body__env_50_008)
{
   mapTo = "body__env_50_008";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/body.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_body__prim_e_004)
{
   mapTo = "body__prim_e_004";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/body.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_salon__spec__004)
{
   mapTo = "salon__spec__004";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/salon.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/salon.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_body__env_50_009)
{
   mapTo = "body__env_50_009";
   diffuseColor[0] = "0 0 0 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "Add";
   diffuseColor[1] = "0.00392157 0.00392157 0.00392157 1";
   translucent = "1";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_Matte__FF746_004)
{
   mapTo = "Matte__FF746_004";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseColor[1] = "0.00392157 0.00392157 0.00392157 1";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/body.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_body__spec__005)
{
   mapTo = "body__spec__005";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseColor[1] = "0.00392157 0.00392157 0.00392157 1";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/body.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_body__prim_e_006)
{
   mapTo = "body__prim_e_006";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/body.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_whitea128a___002)
{
   mapTo = "whitea128a___002";
   diffuseColor[0] = "0.00392157 0.00392157 0.00392157 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "Add";
   translucent = "1";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_whitea128a___002)
{
   mapTo = "whitea128a___002";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
};

singleton Material(lexus_is300_body__env_50_010)
{
   mapTo = "body__env_50_010";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_lights__env__006)
{
   mapTo = "lights__env__006";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/lights.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/lights.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_body__spec__004)
{
   mapTo = "body__spec__004";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseColor[1] = "0.00392157 0.00392157 0.00392157 1";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/body.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_body__env_50_007)
{
   mapTo = "body__env_50_007";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseColor[1] = "0.00392157 0.00392157 0.00392157 1";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/body.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_Matte__FFFF3_003)
{
   mapTo = "Matte__FFFF3_003";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseColor[1] = "0.00392157 0.00392157 0.00392157 1";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/body.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_carpet__spec_003)
{
   mapTo = "carpet__spec_003";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/carpet.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/carpet.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_under2__spec_003)
{
   mapTo = "under2__spec_003";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/under2.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/under2.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_Matte__FFFFA_003)
{
   mapTo = "Matte__FFFFA_003";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseColor[1] = "0.00392157 0.00392157 0.00392157 1";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/body.png";
   glow[1] = "1";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_body__spec__003)
{
   mapTo = "body__spec__003";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseColor[1] = "0.00392157 0.00392157 0.00392157 1";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/body.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_body__spec__003)
{
   mapTo = "body__spec__003";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
};

singleton Material(lexus_is300_under__spec__003)
{
   mapTo = "under__spec__003";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/under.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/under.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_digits__spec_003)
{
   mapTo = "digits__spec_003";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/digits.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/digits.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_seat__spec__003)
{
   mapTo = "seat__spec__003";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/seat.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/seat.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_lights__env__004)
{
   mapTo = "lights__env__004";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/lights.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/lights.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_Matte__FF00F_003)
{
   mapTo = "Matte__FF00F_003";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/body.png";
   glow[1] = "0";
   materialTag0 = "Miscellaneous";
   diffuseColor[1] = "0.00392157 0.00392157 0.00392157 1";
};

singleton Material(lexus_is300_salon__spec__003)
{
   mapTo = "salon__spec__003";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/salon.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/salon.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_Matte__FFB9F_003)
{
   mapTo = "Matte__FFB9F_003";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseColor[1] = "0.00392157 0.00392157 0.00392157 1";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/body.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_Matte__FF746_003)
{
   mapTo = "Matte__FF746_003";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseColor[1] = "0.00392157 0.00392157 0.00392157 1";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/body.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_trunc__spec__003)
{
   mapTo = "trunc__spec__003";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/trunc.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/trunc.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_rim__spec__003)
{
   mapTo = "rim__spec__003";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/rim.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/rim.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_engine__spec_003)
{
   mapTo = "engine__spec_003";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/engine.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/engine.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_body__env_50_004)
{
   mapTo = "body__env_50_004";
   diffuseColor[0] = "0.207843 0.207843 0.207843 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[0] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[0] = "vehicles/lexus_is300/erefh/body.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_body__env_50_005)
{
   mapTo = "body__env_50_005";
   diffuseColor[0] = "0.00392157 0.00392157 0.00392157 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "Add";
   translucent = "1";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_body__env_50_006)
{
   mapTo = "body__env_50_006";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseColor[1] = "0.00392157 0.00392157 0.00392157 1";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/body.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/body.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_lights__env__005)
{
   mapTo = "lights__env__005";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/lights.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/lights.png";
   materialTag0 = "Miscellaneous";
};

singleton Material(lexus_is300_lights__env__005)
{
   mapTo = "lights__env__005";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
};

singleton Material(lexus_is300_T_DISK)
{
   mapTo = "T_DISK";
   diffuseColor[0] = "0 0 0 1";
   specular[0] = "0.25 0.25 0.25 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[1] = "vehicles/lexus_is300/erefh/brake.png";
   specularMap[1] = "vehicles/lexus_is300/erefh/brake.png";
   materialTag0 = "Miscellaneous";
};
