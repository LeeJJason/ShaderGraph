## 13、无贴图火焰效果，主要节点：Voronoi、Tiling And Offset、Blend
原理：通过两个Voronoi的融合，得到类似火焰向上燃烧的形状，再通过UV和一个Vector 2的Distance制造两个圆形区域，分别作为火焰内心和外围的区域，再合火焰形状相乘，最后再乘上颜色。

![](20200826091139494.gif)