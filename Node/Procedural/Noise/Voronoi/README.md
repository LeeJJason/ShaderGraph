# [Voronoi Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Voronoi-Node.html)

## Description
根据输入的UV生成Voronoi或Worley噪声。 Voronoi噪声是通过计算像素与点阵之间的距离生成的。通过将这些点偏移一个伪随机数（由输入角度偏移控制），可以生成一个单元簇。这些单元格的大小以及由此产生的噪声由输入单元格密度控制。输出单元格包含原始单元格数据。

## Ports
|Name|Direction|Type|Binding|Description
|:---|:--------|:---|:------|:------
|UV|Input|Vector 2|UV|Input UV value
|Angle Offset|Input|Vector 1|None|Offset value for points
|Cell Density|Input|Vector 1|None|Density of cells generated
|Out|Output|Vector 1|None|Output noise value
|Cells|Output|Vector 1|None|Raw cell data

## Generated Code Example
```h
inline float2 unity_voronoi_noise_randomVector (float2 UV, float offset)
{
    float2x2 m = float2x2(15.27, 47.63, 99.41, 89.98);
    UV = frac(sin(mul(UV, m)) * 46839.32);
    return float2(sin(UV.y*+offset)*0.5+0.5, cos(UV.x*offset)*0.5+0.5);
}

void Unity_Voronoi_float(float2 UV, float AngleOffset, float CellDensity, out float Out, out float Cells)
{
    float2 g = floor(UV * CellDensity);
    float2 f = frac(UV * CellDensity);
    float t = 8.0;
    float3 res = float3(8.0, 0.0, 0.0);

    for(int y=-1; y<=1; y++)
    {
        for(int x=-1; x<=1; x++)
        {
            float2 lattice = float2(x,y);
            float2 offset = unity_voronoi_noise_randomVector(lattice + g, AngleOffset);
            float d = distance(lattice + offset, f);
            if(d < res.x)
            {
                res = float3(d, offset.x, offset.y);
                Out = res.x;
                Cells = res.y;
            }
        }
    }
}
```