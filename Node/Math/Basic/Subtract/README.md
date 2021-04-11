# [Subtract Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Subtract-Node.html)

## Description
返回输入A减去输入B的结果。

## Ports

|Name|Direction|Type|Description
|:---|:--------|:---|:--------
|A|Input|Dynamic Vector|First input value
|B|Input|Dynamic Vector|Second input value
|Out|Output|Dynamic Vector|Output value

## Generated Code Example
```h
void Unity_Subtract_float4(float4 A, float4 B, out float4 Out)
{
    Out = A - B;
}
```