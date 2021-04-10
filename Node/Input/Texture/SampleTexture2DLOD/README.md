# [Sample Texture 2D LOD Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Sample-Texture-2D-LOD-Node.html)

## Description
采样**Texture 2D**并返回**Vector 4**颜色值以供着色器使用。您可以使用**UV**输入覆盖UV坐标，并使用**Sampler**输入定义自定义**Sampler State**。使用**LOD**输入来调整样本的细节水平。

要使用**Sample Texture 2D LOD Node**节点采样法线贴图，请将**Type**下拉参数设置为**Normal**。


该节点可用于在顶点着色器阶段对纹理进行采样，因为 [**Sample Texture 2D Node**](../sampletexture2d/README.md)节点在此着色器阶段不可用。

## Ports
|Name|Direction|Type|Binding|Description
|:---|:--------|:---|:------|:-----
|Texture|Input|Texture 2D|None|Texture 2D to sample
|UV|Input|Vector 2|UV|Mesh's normal vector
|Sampler|Input|Sampler State|Default sampler state|Sampler for the texture
|LOD|Input|Vector 1|None|Level of detail to sample
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
float4 _SampleTexture2DLOD_RGBA = SAMPLE_TEXTURE2D_LOD(Texture, Sampler, UV, LOD);
float _SampleTexture2DLOD_R = _SampleTexture2DLOD_RGBA.r;
float _SampleTexture2DLOD_G = _SampleTexture2DLOD_RGBA.g;
float _SampleTexture2DLOD_B = _SampleTexture2DLOD_RGBA.b;
float _SampleTexture2DLOD_A = _SampleTexture2DLOD_RGBA.a;
```

**Normal**
```h
float4 _SampleTexture2DLOD_RGBA = SAMPLE_TEXTURE2D_LOD(Texture, Sampler, UV, LOD);
_SampleTexture2DLOD_RGBA.rgb = UnpackNormalRGorAG(_SampleTexture2DLOD_RGBA);
float _SampleTexture2DLOD_R = _SampleTexture2DLOD_RGBA.r;
float _SampleTexture2DLOD_G = _SampleTexture2DLOD_RGBA.g;
float _SampleTexture2DLOD_B = _SampleTexture2DLOD_RGBA.b;
float _SampleTexture2DLOD_A = _SampleTexture2DLOD_RGBA.a;
```