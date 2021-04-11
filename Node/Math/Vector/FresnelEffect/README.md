# [Fresnel Effect Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Fresnel-Effect-Node.html)


## Description
**Fresnel Effect**是取决于视角的表面反射率不同的效果，当您接近掠射角时，会反射更多的光。**Fresnel Effect**节点通过计算表面法线和视图方向之间的角度来近似此值。该角度越宽，返回值将越大。这种效果通常用于实现许多艺术风格中常见的边缘照明。

## Ports

|Name|Direction|Type|Description
|:---|:--------|:---|:-----
|Normal|Input|Vector 3|Normal direction. By default bound to World Space Normal
|View Dir|Input|Vector 3|View direction. By default bound to World Space View Direction
|Power|Input|Vector 1|Exponent of the power calculation
|Out|Output|Vector 1|Output value

## Generated Code Example
```h
void Unity_FresnelEffect_float(float3 Normal, float3 ViewDir, float Power, out float Out)
{
    Out = pow((1.0 - saturate(dot(normalize(Normal), normalize(ViewDir)))), Power);
}
```