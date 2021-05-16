# [Preview Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Preview-Node.html)

## Description
提供预览窗口，并直接传递输入值，而无需进行修改。
如果用户更喜欢总体折叠节点预览，则此节点可用于在着色器图中的特定点提供预览。

## Ports
|Name|Direction|Type|Binding|Description
|:---|:--------|:---|:------|:------
|In|Input|Dynamic Vector|None|Input value
|Out|Output|Dynamic Vector|None|Output value

## Generated Code Example
```h
void Unity_Preview_float4(float4 In, out float4 Out)
{
    Out = In;
}
```