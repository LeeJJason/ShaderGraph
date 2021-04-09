# [Position Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Position-Node.html)

## Description
提供网格顶点或片段位置的访问，具体取决于节点所属的图形部分的有效[Shader Stage](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Shader-Stage.html)。
使用“空间”下拉参数选择输出值的坐标空间。

## Ports
|Name|Direction|Type|Binding|Description
|:---|:--------|:---|:-----|:-----
|Out|Output|Vector 3|None|Position for the Mesh Vertex/Fragment.
## Controls
|Name|Type|Options|Description
|:---|:--------|:---|:-----
|Space|Dropdown|Object, View, World, Tangent, Absolute World|Selects the coordinate space of Position to output.

## World and Absolute World
位置节点为**World**和**Absolute World**空间位置提供下拉选项。
对于所有可编写脚本的渲染管线，**Absolute World**选项始终返回场景中对象的绝对世界位置。 
**World**选项返回选定的“可脚本编写的渲染管道”的默认世界空间。


[High Definition Render Pipeline](https://docs.unity3d.com/Packages/com.unity.render-pipelines.high-definition@10.4/index.html)使用[Camera Relative](https://docs.unity3d.com/Packages/com.unity.render-pipelines.high-definition@latest?preview=1&subfolder=/manual/Camera-Relative-Rendering.html)作为其默认世界空间。


[Universal Render Pipeline](https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@10.4/manual/index.html)使用**Absolute World**作为其默认世界空间。

### Upgrading from previous versions
如果在使用Shader Graph 6.7.0或更早版本创作的图形上的“世界”空间中使用“位置节点”，它将自动将所选内容升级到**Absolute World**。这可以确保图形上的计算保持准确，符合您的期望，因为**World**输出可能会发生变化。

如果您在 High Definition Render Pipeline中使用“世界空间中的位置节点”来手动计算“摄影机相对世界”空间，现在可以将节点从“绝对世界”更改为“世界”，这使您可以立即使用“摄影机相对世界”空间。