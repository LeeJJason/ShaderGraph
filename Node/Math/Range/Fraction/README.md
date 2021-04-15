# [Fraction Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Fraction-Node.html)

## Description
返回输入In的小数（或小数）部分；大于或等于0且小于1。

## Ports
|Name|Direction|Type|Description
|:---|:--------|:---|:------
|In|Input|Dynamic Vector|Input value
|Out|Output|Dynamic Vector|Output value

## Generated Code Example
```h
void Unity_Fraction_float4(float4 In, out float4 Out)
{
    Out = frac(In);
}
```