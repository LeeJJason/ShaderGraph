# [Sampler State Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Sampler-State-Node.html)


## Description
定义用于采样纹理的**Sampler State**。它应与采样节点（例如**Sample Texture 2D Node**）结合使用。
您可以使用下拉参数**Filter**设置过滤器模式，并使用下拉参数**Wrap**设置环绕模式。

使用单独的**Sample State Node**时，可以使用不同的采样器参数对Texture 2D进行两次采样，而无需两次定义Texture 2D本身。

某些过滤和环绕模式仅在某些平台上可用。

## Ports
|Name|Direction|Type|Binding|Description
|:---|:--------|:---|:------|:-----
|Out|Output|Sampler State|None|Output value

## Controls

|Name|Type|Options|Description
|:---|:---|:------|:-------
|Filter|Dropdown|Linear, Point, Trilinear|Defines filtering mode for sampling.
|Wrap|Dropdown|Repeat, Clamp, Mirror, MirrorOnce|Defines wrap mode for sampling.

## Generated Code Example
```h
SamplerState _SamplerState_Out = _SamplerState_Linear_Repeat_sampler;
```