# [Negate Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Negate-Node.html)

## Description
返回输入In的翻转符号值。正值变为负值，负值变为正值。

## Ports

|Name|Direction|Type|Description
|:---|:--------|:---|:------
|In|Input|Dynamic Vector|Input value
|Out|Output|Dynamic Vector|Output value

## Generated Code Example
```h
void Unity_Negate_float4(float4 In, out float4 Out)
{
    Out = -1 * In;
}
```