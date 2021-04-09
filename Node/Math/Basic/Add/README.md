# [Add Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Add-Node.html)


## Description
返回两个输入A 和 B 值得和。

## Ports
|Name|Direction|Type|Description
|:---|:--------|:---|:-----
|A|Input|Dynamic Vector|First input value
|B|Input|Dynamic Vector|Second input value
|Out|Output|Dynamic Vector|Output value

## Generated Code Example
以下示例代码表示此节点的一种可能结果。
```h
void Unity_Add_float4(float4 A, float4 B, out float4 Out)
{
    Out = A + B;
}
```