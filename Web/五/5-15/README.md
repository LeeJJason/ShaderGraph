## 15、无贴图闪电效果，主要节点：Simple Noise、Rectangle
原理：噪声通过Rectangle后，可以形成类似闪电的形状

![](20200826141945907.png)

一个UV向下移动的噪声和一个UV向上移动的噪声相加，再通过Rectangle，则可以形成动态闪电效果  
![](20200826141606140.gif)