# [Distance Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Distance-Node.html)

## Description
返回输入A和B的值之间的欧几里得距离。除其他事项外，这对于计算空间中两个点之间的距离很有用，通常用于计算[Signed Distance Function](https://en.wikipedia.org/wiki/Signed_distance_function)。

## Ports
|Name|Direction|Type|Description
|:---|:--------|:---|:------
|A|Input|Dynamic Vector|First input value
|B|Input|Dynamic Vector|Second input value
|Out|Output|Vector 1|Output value

## Generated Code Example
```h
void Unity_Distance_float4(float4 A, float4 B, out float Out)
{
    Out = distance(A, B);
}
```