# [Time Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Time-Node.html)

## Description
提供对着色器中各种`Time`参数的访问。

## Ports
|Name|Direction|Type|Binding|Description
|:---|:--------|:---|:------|:-----
|Time|Output|Vector 1|None|Time value
|Sine Time|Output|Vector 1|None|Sine of Time value
|Cosine Time|Output|Vector 1|None|Cosine of Time value
|Delta Time|Output|Vector 1|None|Current frame time
|Smooth Delta|Output|Vector 1|None|Current frame time smoothed

## Generated Code Example
```h
float Time_Time = _Time.y;
float Time_SineTime = _SinTime.w;
float Time_CosineTime = _CosTime.w;
float Time_DeltaTime = unity_DeltaTime.x;
float Time_SmoothDelta = unity_DeltaTime.z;
```

* Time_Time 在场景切换后会清零，重新计数。