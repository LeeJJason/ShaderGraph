# [Gradient Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Gradient-Node.html)

## Description
定义用于着色器图形的常量渐变，尽管在着色器内部将其定义为结构。
要对渐变进行采样，应将其与“采样渐变节点”结合使用。
使用单独的“渐变节点”时，可以使用不同的“时间”参数多次采样“渐变”。

## Ports
|Name|Direction|Type|Description
|:---|:--------|:---|:---------
|Out|Output|Gradient|Output value

## Controls
|Name|Type|Options|Description
|:---|:---|:------|:-----
|Gradient Field||Defines the gradient.

## Generated Code Example
```h
Gradient Unity_Gradient_float()
{
    Gradient g;
    g.type = 1;
    g.colorsLength = 4;
    g.alphasLength = 4;
    g.colors[0] = 0.1;
    g.colors[1] = 0.2;
    g.colors[2] = 0.3;
    g.colors[3] = 0.4;
    g.colors[4] = 0;
    g.colors[5] = 0;
    g.colors[6] = 0;
    g.colors[7] = 0;
    g.alphas[0] = 0.1;
    g.alphas[1] = 0.2;
    g.alphas[2] = 0.3;
    g.alphas[3] = 0.4;
    g.alphas[4] = 0;
    g.alphas[5] = 0;
    g.alphas[6] = 0;
    g.alphas[7] = 0;
    return g;
}

Gradient _Gradient = Unity_Gradient_float();
```