# [Clamp Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Clamp-Node.html)

## Description
返回输入In夹在分别由输入Min和Max定义的最小值和最大值之间。

## Generated Code Example
```h
void Unity_Clamp_float4(float4 In, float4 Min, float4 Max, out float4 Out)
{
    Out = clamp(In, Min, Max);
}
```