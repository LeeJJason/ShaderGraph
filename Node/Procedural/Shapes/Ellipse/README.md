# [Ellipse Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Ellipse-Node.html)

## Description
根据输入UV以输入宽度和高度指定的大小生成椭圆形状。可以通过连接`Tiling And Offset Node`来偏移或平铺生成的形状。请注意，为了保持在UV空间内偏移形状的能力，如果平铺了形状，则形状不会自动重复。要获得重复的点效果，请首先通过[Fraction Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Fraction-Node.html)连接输入。


注意：此节点只能在“片段着色器”阶段中使用。

## Ports
|Name|Direction|Type|Binding|Description
|:---|:--------|:---|:------|:-------
|UV|Input|Vector 2|UV|Input UV value
|Width|Input|Vector 1|None|Ellipse width
|Height|Input|Vector 1|None|Ellipse height
|Out|Output|Vector 1|None|Output value

## Generated Code Example
```h
void Unity_Ellipse_float(float2 UV, float Width, float Height, out float4 Out)
{
    float d = length((UV * 2 - 1) / float2(Width, Height));
    Out = saturate((1 - d) / fwidth(d));
}
```