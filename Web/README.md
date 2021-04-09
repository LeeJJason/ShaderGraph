# [一、ShaderGraph前言](./一/README.md)
# [二、ShaderGraph科普](./二/README.md)
    1、渲染管线（Render Pipline）
    2、可编程渲染管线，SRP（Scriptable Render Pipline）
    3、高清渲染管线，HDRP（High Definition Render Pipleline）
    4、通用渲染管线，URP（Universal Render Pipleline）
    5、ShaderGraph
    6、URP和HDRP效果对比
# [三、ShaderGraph使用前的环境准备](./三/README.md)
    1、安装Universal RP
    2、创建Pipeline Assets
    3、设置Pipeline Assets
# [四、ShaderGraph入门：PBR Graph的简单使用](./四/README.md)
    1、创建PBR Graph
    2、创建一个颜色变量
    3、将Color变量连到Master节点中
    4、保存ShaderGraph文件
    5、将ShaderGraph赋值给Material材质球
    6、将材质球赋值给3D模型
# [五、ShaderGraph进阶：实战特效案例](./五/README.md)
    1、模型裁切，主要节点、Position、AlphaClip
    2、模型溶解，主要节点：Simple Noise、AlphaClip
    3、边缘光效果，主要节点：Fresnel Effect
    4、卡通阴影色块效果，主要节点：Normal Vector、Dot Product、Sample Gradient
    5、表面水纹叠加，主要节点：Tilling And Offset、Lerp
    6、积雪效果，主要节点：Nomal Vector、Dot Product
    7、不锈钢效果、冰晶效果，主要节点：View Direction、Tilling And Offset、Simple Noise
    8、UV抖动效果，主要节点：UV、Simple Noise、Split
    9、水面上下波动效果，主要节点：Gradient Noise、Position
    10、红旗飘飘效果，主要节点：Simple Noise、UV、Position
    11、马赛克效果，主要节点：UV、Posterize
    12、无贴图水球效果，主要节点：UV、Ellipse、Step
    13、无贴图火焰效果，主要节点：Voronoi、Tiling And Offset、Blend
    14、无贴图旋涡效果，主要节点：Twirl、Voronoi
    15、无贴图闪电效果，主要节点：Simple Noise、Rectangle
    16、全息效果，主要节点：Position、Fraction、Time、Fresnel Effect
    17、水波纹效果，主要节点：UV、Sine
    18、高斯模糊
    19、自发光
    20、粒子系统溶解效果
    21、物体靠近局部溶解效果
    22、2D描边效果
    23、子弹拖尾效果
    24、在模型上涂鸦
    25、刮刮乐效果