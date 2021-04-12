# [View Direction Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/View-Direction-Node.html)


## Description
提供对网格顶点或片段的**View Direction**矢量的访问。这是从顶点或片段到摄影机的向量。可以使用**Space**下拉参数选择输出值的坐标空间。

## Ports
|Name|Direction|Type|Binding|Description
|:---|:--------|:---|:------|:------
|Out|Output|Vector 3|None|View Direction for the Mesh Vertex/Fragment.


## Controls
|Name|Type|Options|Description
|:---|:---|:------|:-------
|Space|Dropdown|Object, View, World, Tangent|Selects coordinate space of View Direction to output.