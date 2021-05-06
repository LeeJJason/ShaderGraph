# [Rectangle Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Rectangle-Node.html)

## Description
根据输入UV以输入Width和Height指定的大小生成矩形形状。
可以通过连接平铺和偏移节点来偏移或平铺生成的形状。
请注意，为了保持在UV空间内偏移形状的能力，如果平铺了形状，则形状不会自动重复。
要实现重复的矩形效果，请首先通过小数节点连接输入。


注意：此节点只能在“片段着色器”阶段中使用。

## Ports
|Name|Direction|Type|Binding|Description
|:---|:--------|:---|:------|:-----
|UV|Input|Vector 2|UV|Input UV value
|Width|Input|Vector 1|None|Rectangle width
|Height|Input|Vector 1|None|Rectangle height
|Out|Output|Vector 1|None|Output value


## Generated Code Example
```h
void Unity_Rectangle_float(float2 UV, float Width, float Height, out float Out)
{
    float2 d = abs(UV * 2 - 1) - float2(Width, Height);
    d = 1 - d / fwidth(d);
    Out = saturate(min(d.x, d.y));
}
```