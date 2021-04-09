# [One Minus Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/One-Minus-Node.html)

## Description
返回1减去输入In的结果。

## Ports
|Name|Direction|Type|Description
|:---|:--------|:---|:-----
|In|Input|Dynamic Vector|Input value
|Out|Output|Dynamic Vector|Output value

## Generated Code Example
```h
void Unity_OneMinus_float4(float4 In, out float4 Out)
{
    Out = 1 - In;
}
```