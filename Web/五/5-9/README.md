## 9、水面上下波动效果，主要节点：Gradient Noise、Position
原理：原理：使用Gradient Noise随机噪声，再通过一个 Normal Vector结点，代表垂直于物体的法向量，接着，对Position进行一个叠加。注意Normal Vector和Position的Space都选择Object空间

![](20200821090243176.gif)