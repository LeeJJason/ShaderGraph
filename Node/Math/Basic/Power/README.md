# [Power Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Power-Node.html)

## Description
Returns the result of input A to the power of input B.

## Ports
|Name|Direction|Type|Description
|:---|:--------|:---|:------
|A|Input|Dynamic Vector|First input value
|B|Input|Dynamic Vector|Second input value
|Out|Output|Dynamic Vector|Output value

## Generated Code Example
```h
void Unity_Power_float4(float4 A, float4 B, out float4 Out)
{
    Out = pow(A, B);
}
```

## NOTE
The pow HLSL intrinsic function calculates xy.

REMARKS
|X|Y|Result
|:---|:---|:---
|< 0|any|NAN
|> 0|== 0|1
|== 0|> 0|0
|== 0|< 0|inf
|> 0|< 0|1/X-Y
|== 0|== 0|Depends on the particular graphics processor
0, or 1, or NAN