# [Step Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Step-Node.html)
## Description
对于每个组件，如果输入In的值大于或等于输入Edge的值，则返回1，否则返回0。

## Ports

|Name|Direction|Type|Description|
|:----|:-----|:-----|:----|
|Edge|Input|Dynamic Vector|Step value|
|In|Input|Dynamic Vector|Input value|
|Out|Output|Dynamic Vector|Output value|

## Generated Code Example
以下示例代码表示此节点的一种可能结果。
```h
void Unity_Step_float4(float4 Edge, float4 In, out float4 Out)
{
    Out = step(Edge, In);
}
```

[ret step(y, x) 函数说明](https://docs.microsoft.com/en-gb/windows/win32/direct3dhlsl/dx-graphics-hlsl-step)
```
(x >= y) ? 1 : 0
```