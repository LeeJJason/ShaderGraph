# [Dot Product Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Dot-Product-Node.html)

## Description
返回两个输入向量A和B的点积或标量积。

点积是一个值，该值等于两个向量的大小相乘在一起，然后乘以它们之间的角度的余弦值。

对于归一化的输入向量，如果点指向完全相同的方向，则“点积”节点将返回1；如果它们指向完全相反的方向，则将返回-1；如果向量垂直，则返回0。

## Ports

|Name|Direction|Type|Description
|:---|:--------|:---|:-------
|A|Input|Dynamic Vector|First input value
|B|Input|Dynamic Vector|Second input value
|Out|Output|Vector 1|Output value

## Generated Code Example
```h
void Unity_DotProduct_float4(float4 A, float4 B, out float Out)
{
    Out = dot(A, B);
}
```