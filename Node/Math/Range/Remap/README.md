# [Remap Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Remap-Node.html)

## Description
根据输入 **In** 的值在输入 **In Min Max** 中 X, Y 分量间线性插值，返回输入**Out Min Max**中 X, Y 分量之间的值。

## Ports
|Name|Direction|Type|Description
|:---|:-----|:-----|:----
|In|Input|Dynamic Vector|Input value
|In Min Max|Input|Vector 2|Minimum and Maximum values for input interpolation
|Out Min Max|Input|Vector 2|Minimum and Maximum values for output interpolation
|Out|Output|Dynamic Vector|Output value

## Generated Code Example
以下示例代码表示此节点的一种可能结果。
```h
void Unity_Remap_float4(float4 In, float2 InMinMax, float2 OutMinMax, out float4 Out)
{
    Out = OutMinMax.x + (In - InMinMax.x) * (OutMinMax.y - OutMinMax.x) / (InMinMax.y - InMinMax.x);
}
```