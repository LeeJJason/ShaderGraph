# [Sample Texture 2D Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Sample-Texture-2D-Node.html)

## Description
采样**Texture 2D**并返回**Vector 4**颜色值以供着色器使用。您可以使用**UV**输入覆盖UV坐标，并使用**Sampler**输入定义自定义**Sampler State**。

要使用**Sample Texture 2D Node**来采样法线贴图，请将**Type**下拉参数设置为**Normal**。


注意：此节点只能在**Fragment Shader Stage**阶段中使用。要在**Vertex Shader Stage**阶段中对**Texture 2D**进行采样，请改用[**Sample Texture 2D LOD Node**](../SampleTexture2DLOD/README.md)节点。

## Ports
|Name|Direction|Type|Binding|Description
|:---|:--------|:---|:------|:----
|Texture|Input|Texture 2D|None|Texture 2D to sample
|UV|Input|Vector 2|UV|Mesh's normal vector
|Sampler|Input|Sampler State|Default sampler state|Sampler for the texture
|RGBA|Output|Vector 4|None|Output value as RGBA
|R|Output|Vector 1|None|red (x) component of RGBA output
|G|Output|Vector 1|None|green (y) component of RGBA output
|B|Output|Vector 1|None|blue (z) component of RGBA output
|A|Output|Vector 1|None|alpha (w) component of RGBA output


## Controls
|Name|Type|Options|Description
|:---|:---|:------|:----
|Type|Dropdown|Default, Normal|Selects the texture type


## Generated Code Example
**Default**
```h
float4 _SampleTexture2D_RGBA = SAMPLE_TEXTURE2D(Texture, Sampler, UV);
float _SampleTexture2D_R = _SampleTexture2D_RGBA.r;
float _SampleTexture2D_G = _SampleTexture2D_RGBA.g;
float _SampleTexture2D_B = _SampleTexture2D_RGBA.b;
float _SampleTexture2D_A = _SampleTexture2D_RGBA.a;
```

**Normal**
```h
float4 _SampleTexture2D_RGBA = SAMPLE_TEXTURE2D(Texture, Sampler, UV);
_SampleTexture2D_RGBA.rgb = UnpackNormalRGorAG(_SampleTexture2D_RGBA);
float _SampleTexture2D_R = _SampleTexture2D_RGBA.r;
float _SampleTexture2D_G = _SampleTexture2D_RGBA.g;
float _SampleTexture2D_B = _SampleTexture2D_RGBA.b;
float _SampleTexture2D_A = _SampleTexture2D_RGBA.a;
```