# Twirl Node
## Description
将类似于黑洞的旋转扭曲效果应用于输入UV的值。变形效果的中心参考点由输入Center定义，效果的整体强度由输入Strength的值定义。
输入偏移量可用于偏移结果的各个通道。

## Ports
|Name|Direction|Type|Binding|Description
|:---|:--------|:---|:------|:--------
|UV|Input|Vector 2|UV|Input UV value
|Center|Input|Vector 2|None|Center reference point
|Strength|Input|Vector 1|None|Strength of the effect
|Offset|Input|Vector 2|None|Individual channel offsets
|Out|Output|Vector 2|None|Output UV value

## Generated Code Example
```h
void Unity_Twirl_float(float2 UV, float2 Center, float Strength, float2 Offset, out float2 Out)
{
    float2 delta = UV - Center;
    float angle = Strength * length(delta);
    float x = cos(angle) * delta.x - sin(angle) * delta.y;
    float y = sin(angle) * delta.x + cos(angle) * delta.y;
    Out = float2(x + Center.x + Offset.x, y + Center.y + Offset.y);
}
```
