# [Inverse Lerp Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Inverse-Lerp-Node.html)

## Description
返回线性参数，该线性参数生成输入T在输入A到输入B范围内的输入T所指定的插值。


Lerp逆运算是Lerp节点的逆运算。它可以用于根据其输出确定Lerp的输入。


例如，T值为1的0到2之间的Lerp值为0.5。因此，介于0到2之间且T值为0.5的Inverse Lerp的值为1。

## Ports

|Name|Direction|Type|Description
|:---|:--------|:---|:----
|A|Input|Dynamic Vector|First input value
|B|Input|Dynamic Vector|Second input value
|T|Input|Dynamic Vector|Time value
|Out|Output|Dynamic Vector|Output value

## Generated Code Example

```h
void Unity_InverseLerp_float4(float4 A, float4 B, float4 T, out float4 Out)
{
    Out = (T - A)/(B - A);
}
```