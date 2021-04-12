# [Camera Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Camera-Node.html)

## Description
提供对当前用于渲染的“摄影机”的各种参数的访问。它由相机的GameObject的值（例如“位置”和“方向”）以及各种投影参数组成。

Unity Render Pipelines Support
* Universal Render Pipeline

High Definition Render Pipeline 不支持该节点

## Ports
|Name|Direction|Type|Binding|Description
|:---|:--------|:---|:------|:------
|Position|Output|Vector 3|None|Position of the Camera's GameObject in world space
|Direction|Output|Vector 3|None|The Camera's forward vector direction
|Orthographic|Output|Vector 1|None|Returns 1 if the Camera is orthographic, otherwise 0
|Near Plane|Output|Vector 1|None|The Camera's near plane distance
|Far Plane|Output|Vector 1|None|The Camera's far plane distance
|Z Buffer Sign|Output|Vector 1|None|Returns -1 when using a reversed Z Buffer, otherwise 1
|Width|Output|Vector 1|None|The Camera's width if orthographic
|Height|Output|Vector 1|None|The Camera's height if orthographic

## Generated Code Example
```h
float3 _Camera_Position = _WorldSpaceCameraPos;
float3 _Camera_Direction = -1 * mul(UNITY_MATRIX_M, transpose(mul(UNITY_MATRIX_I_M, UNITY_MATRIX_I_V)) [2].xyz);
float _Camera_Orthographic = unity_OrthoParams.w;
float _Camera_NearPlane = _ProjectionParams.y;
float _Camera_FarPlane = _ProjectionParams.z;
float _Camera_ZBufferSign = _ProjectionParams.x;
float _Camera_Width = unity_OrthoParams.x;
float _Camera_Height = unity_OrthoParams.y;
```