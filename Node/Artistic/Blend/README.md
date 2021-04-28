# [Blend Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Blend-Node.html)

## Description
使用Mode参数定义的混合模式将输入Blend的值混合到输入Base上。混合的强度由输入不透明度定义。不透明度值为0时，将不变地返回输入Base。

## Ports
|Name|Direction|Type|Binding|Description
|:---|:--------|:---|:------|:--------
|Base|Input|Dynamic Vector|None|Base layer value
|Blend|Input|Dynamic Vector|None|Blend layer value
|Opacity|Input|Vector 1|None|Strength of blend
|Out|Output|Dynamic Vector|None|Output value

## Controls
|Name|Type|Options|Description
|:---|:---|:------|:------
|Mode|Dropdown|Burn, Darken, Difference, Dodge, Divide, Exclusion, HardLight, HardMix, Lighten, LinearBurn, LinearDodge, LinearLight, LinearLightAddSub, Multiply, Negation, Overlay, PinLight, Screen, |SoftLight, Subtract, VividLight, Overwrite|Blend mode to apply


## Generated Code Example

**Burn**
```h
void Unity_Blend_Burn_float4(float4 Base, float4 Blend, float Opacity, out float4 Out)
{
    Out =  1.0 - (1.0 - Blend)/Base;
    Out = lerp(Base, Out, Opacity);
}
```

**Darken**
```h
void Unity_Blend_Darken_float4(float4 Base, float4 Blend, float Opacity, out float4 Out)
{
    Out = min(Blend, Base);
    Out = lerp(Base, Out, Opacity);
}
```

**Difference**
```h
void Unity_Blend_Difference_float4(float4 Base, float4 Blend, float Opacity, out float4 Out)
{
    Out = abs(Blend - Base);
    Out = lerp(Base, Out, Opacity);
}
```

**Dodge**
```h
void Unity_Blend_Dodge_float4(float4 Base, float4 Blend, float Opacity, out float4 Out)
{
    Out = Base / (1.0 - Blend);
    Out = lerp(Base, Out, Opacity);
}
```
**Divide**
```h
void Unity_Blend_Divide_float4(float4 Base, float4 Blend, float Opacity, out float4 Out)
{
    Out = Base / (Blend + 0.000000000001);
    Out = lerp(Base, Out, Opacity);
}
```

**Exclusion**
```
void Unity_Blend_Exclusion_float4(float4 Base, float4 Blend, float Opacity, out float4 Out)
{
    Out = Blend + Base - (2.0 * Blend * Base);
    Out = lerp(Base, Out, Opacity);
}
```

**HardLight**
```h
void Unity_Blend_HardLight_float4(float4 Base, float4 Blend, float Opacity, out float4 Out)
{
    float4 result1 = 1.0 - 2.0 * (1.0 - Base) * (1.0 - Blend);
    float4 result2 = 2.0 * Base * Blend;
    float4 zeroOrOne = step(Blend, 0.5);
    Out = result2 * zeroOrOne + (1 - zeroOrOne) * result1;
    Out = lerp(Base, Out, Opacity);
}
```

**HardMix**
```h
void Unity_Blend_HardMix_float4(float4 Base, float4 Blend, float Opacity, out float4 Out)
{
    Out = step(1 - Base, Blend);
    Out = lerp(Base, Out, Opacity);
}
```

**Lighten**
```h
void Unity_Blend_Lighten_float4(float4 Base, float4 Blend, float Opacity, out float4 Out)
{
    Out = max(Blend, Base);
    Out = lerp(Base, Out, Opacity);
}
```

**LinearBurn**
```h
void Unity_Blend_LinearBurn_float4(float4 Base, float4 Blend, float Opacity, out float4 Out)
{
    Out = Base + Blend - 1.0;
    Out = lerp(Base, Out, Opacity);
}
```

**LinearDodge**
```h
void Unity_Blend_LinearDodge_float4(float4 Base, float4 Blend, float Opacity, out float4 Out)
{
    Out = Base + Blend;
    Out = lerp(Base, Out, Opacity);
}
```

**LinearLight**
```h
void Unity_Blend_LinearLight_float4(float4 Base, float4 Blend, float Opacity, out float4 Out)
{
    Out = Blend < 0.5 ? max(Base + (2 * Blend) - 1, 0) : min(Base + 2 * (Blend - 0.5), 1);
    Out = lerp(Base, Out, Opacity);
}
```

**LinearLightAddSub**
```h
void Unity_Blend_LinearLightAddSub_float4(float4 Base, float4 Blend, float Opacity, out float4 Out)
{
    Out = Blend + 2.0 * Base - 1.0;
    Out = lerp(Base, Out, Opacity);
}
```
**Multiply**
```h
void Unity_Blend_Multiply_float4(float4 Base, float4 Blend, float Opacity, out float4 Out)
{
    Out = Base * Blend;
    Out = lerp(Base, Out, Opacity);
}
```
**Negation**
```h
void Unity_Blend_Negation_float4(float4 Base, float4 Blend, float Opacity, out float4 Out)
{
    Out = 1.0 - abs(1.0 - Blend - Base);
    Out = lerp(Base, Out, Opacity);
}
```
**Overlay**
```h
void Unity_Blend_Overlay_float4(float4 Base, float4 Blend, float Opacity, out float4 Out)
{
    float4 result1 = 1.0 - 2.0 * (1.0 - Base) * (1.0 - Blend);
    float4 result2 = 2.0 * Base * Blend;
    float4 zeroOrOne = step(Base, 0.5);
    Out = result2 * zeroOrOne + (1 - zeroOrOne) * result1;
    Out = lerp(Base, Out, Opacity);
}
```
**PinLight**
```h
void Unity_Blend_PinLight_float4(float4 Base, float4 Blend, float Opacity, out float4 Out)
{
    float4 check = step (0.5, Blend);
    float4 result1 = check * max(2.0 * (Base - 0.5), Blend);
    Out = result1 + (1.0 - check) * min(2.0 * Base, Blend);
    Out = lerp(Base, Out, Opacity);
}
```
**Screen**
```h
void Unity_Blend_Screen_float4(float4 Base, float4 Blend, float Opacity, out float4 Out)
{
    Out = 1.0 - (1.0 - Blend) * (1.0 - Base);
    Out = lerp(Base, Out, Opacity);
}
```
**SoftLight**
```h
void Unity_Blend_SoftLight_float4(float4 Base, float4 Blend, float Opacity, out float4 Out)
{
    float4 result1 = 2.0 * Base * Blend + Base * Base * (1.0 - 2.0 * Blend);
    float4 result2 = sqrt(Base) * (2.0 * Blend - 1.0) + 2.0 * Base * (1.0 - Blend);
    float4 zeroOrOne = step(0.5, Blend);
    Out = result2 * zeroOrOne + (1 - zeroOrOne) * result1;
    Out = lerp(Base, Out, Opacity);
}
```
**Subtract**
```h
void Unity_Blend_Subtract_float4(float4 Base, float4 Blend, float Opacity, out float4 Out)
{
    Out = Base - Blend;
    Out = lerp(Base, Out, Opacity);
}
```
**VividLight**
```h
void Unity_Blend_VividLight_float4(float4 Base, float4 Blend, float Opacity, out float4 Out)
{
    float4 result1 = 1.0 - (1.0 - Blend) / (2.0 * Base);
    float4 result2 = Blend / (2.0 * (1.0 - Base));
    float4 zeroOrOne = step(0.5, Base);
    Out = result2 * zeroOrOne + (1 - zeroOrOne) * result1;
    Out = lerp(Base, Out, Opacity);
}
```
**Overwrite**
```h
void Unity_Blend_Overwrite_float4(float4 Base, float4 Blend, float Opacity, out float4 Out)
{
    Out = lerp(Base, Blend, Opacity);
}
```