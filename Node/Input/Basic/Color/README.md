# [Color Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Color-Node.html)

## Description
使用“颜色”字段在着色器中定义恒定的Vector 4值。可以通过节点的上下文菜单转换为颜色类型属性。生成属性时，还将使用Mode参数的值。

## Ports
|Name|Direction|Type|Binding|Description
|:----|--------|:---|:------|:-----
|Out|Output|Vector 4|None|Output value

## Controls
|Name|Type|Options|Description
|:---|:---|:------|:-----
||Color|Defines the output value.
|Mode|Dropdown|Default, HDR|Sets properties of the Color field

## Generated Code Example
```h
float4 _Color = IsGammaSpace() ? float4(1, 2, 3, 4) : float4(SRGBToLinear(float3(1, 2, 3)), 4);
```