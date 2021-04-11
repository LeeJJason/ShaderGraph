## 2、模型溶解，主要节点：Simple Noise、AlphaClip
原理：AlphaClip的值如果比Alpha的值大，则会不显示

![](20200819194506124.gif)

进阶：溶解边缘添加发光，原理就是对Noise噪声做两个Step，然后相减，再乘个颜色，连到Emission发光节点上。

![](20200820093211450.gif)