# [Tiling And Offset Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Tiling-And-Offset-Node.html)

## Description
通过输入“平铺”和“偏移”分别平铺和偏移输入UV的值。通常用于细节贴图和随时间滚动纹理。

## Ports

|Name|Direction|Type|Binding|Description
|:---|:--------|:---|:------|:------
|UV|Input|Vector 2|UV|Input UV value
|Tiling|Input|Vector 2|None|Amount of tiling to apply per channel
|Offset|Input|Vector 2|None|Amount of offset to apply per channel
|Out|Output|Vector 2|None|Output UV value

## Generated Code Example
```h
void Unity_TilingAndOffset_float(float2 UV, float2 Tiling, float2 Offset, out float2 Out)
{
    Out = UV * Tiling + Offset;
}
```