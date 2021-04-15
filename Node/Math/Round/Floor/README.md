# [Floor Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Floor-Node.html)

## Description
返回小于或等于输入In的值的最大整数值或整数。

## Ports
|Name|Direction|Type|Description
|:---|:--------|:---|:-------
|In|Input|Dynamic Vector|Input value
|Out|Output|Dynamic Vector|Output value

## Generated Code Example
```h
void Unity_Floor_float4(float4 In, out float4 Out)
{
    Out = floor(In);
}
```