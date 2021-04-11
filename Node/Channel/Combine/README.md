# [Combine Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Combine-Node.html)

## Description
从四个输入R，G，B和A创建新向量。输出**RGBA**是由输入R，G，B和A组成的**Vector 4**。输出RGB是由输入R，G和B组成的**Vector 3**。输出RG为由输入R和G组成的**Vector 2**。

## Ports
|Name|Direction|Type|Binding|Description
|:---|:--------|:---|:------|:------
|R|Input|Vector 1|None|Defines red channel of output
|G|Input|Vector 1|None|Defines green channel of output
|B|Input|Vector 1|None|Defines blue channel of output
|A|Input|Vector 1|None|Defines alpha channel of output
|RGBA|Output|Vector 4|None|Output value as Vector 4
|RGB|Output|Vector 3|None|Output value as Vector 3
|RG|Output|Vector 2|None|Output value as Vector 2

## Generated Code Example
```h
void Unity_Combine_float(float R, float G, float B, float A, out float4 RGBA, out float3 RGB, out float2 RG)
{
    RGBA = float4(R, G, B, A);
    RGB = float3(R, G, B);
    RG = float2(R, G);
}
```