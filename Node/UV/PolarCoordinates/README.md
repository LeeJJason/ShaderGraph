# [Polar Coordinates Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Polar-Coordinates-Node.html)

## Description
将输入的UV值转换为极坐标。在数学中，极坐标系是二维坐标系，其中平面上的每个点由距参考点的距离和距参考方向的角度确定。


结果是将输入UV的x通道转换为与输入Center值指定的点的距离值，并将相同输入的y通道转换为围绕该点的旋转角度的值。


这些值可以分别通过输入Radial Scale和Length Scale的值进行缩放。

## Ports
|Name|Direction|Type|Binding|Description
|:---|:--------|:---|:------|:--------
|UV|Input|Vector 2|UV|Input UV value
|Center|Input|Vector 2|None|Center reference point
|Radial Scale|Input|Vector 1|None|Scale of distance value
|Length Scale|Input|Vector 1|None|Scale of angle value
|Out|Output|Vector 2|None|Output value


## Generated Code Example
```h
void Unity_PolarCoordinates_float(float2 UV, float2 Center, float RadialScale, float LengthScale, out float2 Out)
{
    float2 delta = UV - Center;
    float radius = length(delta) * 2 * RadialScale;
    float angle = atan2(delta.x, delta.y) * 1.0/6.28 * LengthScale;
    Out = float2(radius, angle);
}
```