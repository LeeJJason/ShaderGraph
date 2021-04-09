# [Lerp Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Lerp-Node.html)

## Description
返回通过输入T在输入A和输入B之间进行线性插值的结果。输入T的值固定在0到1的范围内。


例如，当输入T的值为0时，返回值等于输入A的值，当输入T的值为1时，返回值等于输入B的值，而当输入T的值为0.5时，返回值为A的中点。
两个输入A和B。

## Ports

|Name|Direction|Type|Description
|:---|:--------|:---|:------
|A|Input|Dynamic Vector|First input value
|B|Input|Dynamic Vector|Second input value
|T|Input|Dynamic Vector|Time value
|Out|Output|Dynamic Vector|Output value

## Generated Code Example
```h
void Unity_Lerp_float4(float4 A, float4 B, float4 T, out float4 Out)
{
    Out = lerp(A, B, T);
}
```

[lerp](https://docs.microsoft.com/zh-cn/windows/win32/direct3dhlsl/dx-graphics-hlsl-lerp) 函数说明