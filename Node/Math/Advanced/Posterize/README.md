# [Posterize Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Posterize-Node.html)

## Description
```
图像的后代化或后代化需要将色调的连续灰度转换为较少色调的多个区域，并从一种色调突然转换为另一种色调。
```

[WIKI Posterization](https://en.wikipedia.org/wiki/Posterization)

该节点将输入In的后代（也称为量化）值通过指定的输入Steps返回到值量中。

## Ports

|Name|Direction|Type|Description
|:---|:--------|:---|:------
|In|Input|Dynamic Vector|Input value
|Steps|Input|Dynamic Vector|Input value
|Out|Output|Dynamic Vector|Output value

## Generated Code Example
```h
void Unity_Posterize_float4(float4 In, float4 Steps, out float4 Out)
{
    Out = floor(In / (1 / Steps)) * (1 / Steps);
}
```