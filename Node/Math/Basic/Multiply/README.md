# [Multiply Node](https://docs.unity3d.com/Packages/com.unity.shadergraph@7.3/manual/Multiply-Node.html)

返回输入A乘以输入B的结果。如果两个输入均为向量类型，则输出类型将为向量类型，其维数与这些输入的求值类型相同。  
如果两个输入均为矩阵类型，则输出类型将为与这些输入的评估类型具有相同维的矩阵类型。  
如果一个输入是向量类型，而另一个输入是矩阵类型，则输出类型将是与向量类型输入具有相同尺寸的向量。

## Ports
|Name|Direction|Type|Description
|:---|:--------|:---|:----
|A|Input|Dynamic|First input value
|B|Input|Dynamic|Second input value
|Out|Output|Dynamic|Output value

## Generated Code Example
**Vector * Vector**
```h
void Unity_Multiply_float4_float4(float4 A, float4 B, out float4 Out)
{
    Out = A * B;
}
```
**Vector * Matrix**
```h
void Unity_Multiply_float4_float4x4(float4 A, float4x4 B, out float4 Out)
{
    Out = mul(A, B);
}
```
**Matrix * Matrix**
```h
void Unity_Multiply_float4x4_float4x4(float4x4 A, float4x4 B, out float4x4 Out)
{
    Out = mul(A, B);
}
```