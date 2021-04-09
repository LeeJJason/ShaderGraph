# [PBR Master Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/PBR-Master-Node.html)
## Description
用于基于物理的渲染的主节点。可以在**Workflow**下拉参数定义的**Metallic**或**Specular**工作流模式下使用。

默认情况下，Shader Graph期望您提供给输入**Normal**的值在切线空间中。使用[Transform Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Transform-Node.html)将值转换为切线空间，或使用[Material Options](#material-options)中的**Fragment Normal Space**下拉菜单将所需的坐标空间更改为**Object**或**World**。

## Ports
|Name|Direction|Type|Stage|Binding|Description
|:---|:--------|:-----|:---|:----|:---
|Position|Input|Vector 3|Vertex|None|Defines the absolute object space vertex position per vertex.
|Albedo|Input|Vector 3|Fragment|None|Defines material's albedo value. Expected range 0 - 1.
|Normal|Input|Vector 3|Fragment|Tangent Space Normal|Defines material's normal value. Expects normals in tangent space.
|Emission|Input|Vector 3|Fragment|None|Defines material's emission color value. Expects positive values.
|Metallic|Input|Vector 1|Fragment|None|Defines material's metallic value where 0 is non-metallic and 1 is metallic. Only available in Metallic Workflow mode.
|Specular|Input|Vector 3|Fragment|None|Defines material's specular color value. Expected range 0 - 1. Only available in Specular Workflow mode.
|Smoothness|Input|Vector 1|Fragment|None|Defines material's smoothness value. Expected range 0 - 1.
|Occlusion|Input|Vector 1|Fragment|None|Defines material's ambient occlusion value. Expected range 0 - 1.
|Alpha|Input|Vector 1|Fragment|None|Defines material's alpha value. Used for transparency and/or alpha clip. Expected range 0 - 1.
|Alpha Clip Threshold|Input|Vector 1|Fragment|None|Fragments with an alpha below this value will be discarded. Requires a node connection. Expected range 0 - 1.



## Material Options
单击**PBR Master Node**右上角的齿轮图标可以访问**PBR Master Node**材料选项。
|Name|Type|Options|Description
|:---|:---|:------|:------
|Workflow|Dropdown|Metallic, Specular|Defines workflow mode for the material.
|Surface|Dropdown|Opaque, Transparent|Defines if the material is transparent.
|Blend|Dropdown|Alpha, Premultiply, Additive, Multiply|Defines blend mode of a transparent material.
|Fragment Normal Space|Dropdown|Tangent, Object, World|Defines the coordinate space of the value supplied to the Normal slot.
|Two Sided|Toggle|True, False|If true, both front and back faces of the mesh are rendered.