# [Split Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Split-Node.html)
## Description
将输入向量In分成四个Vector 1输出R，G，B和A。这些输出向量由输入In的各个通道定义；这些通道由输入In的各个通道定义。分别是红色，绿色，蓝色和Alpha。如果输入向量In的尺寸小于4（向量4），则输入中不存在的输出值将为0。

## Ports

|Name|Direction|Type|Binding|Description|
|:---|:----|:----|:----|:---
|In|Input|Dynamic Vector|None|Input value|
|R|Output|Vector 1|None|Red channel from input|
|G|Output|Vector 1|None|Green channel from input|
|B|Output|Vector 1|None|Blue channel from input|
|A|Output|Vector 1|None|Alpha channel from input|

## Generated Code Example
以下示例代码表示此节点的一种可能结果。
```h
float _Split_R = In[0];
float _Split_G = In[1];
float _Split_B = 0;
float _Split_A = 0;
```