## 8、UV抖动效果，主要节点：UV、Simple Noise、Split
原理，使用Split将UV分开成x和y两个分类，对x分类做一个噪音抖动，最后和y再合并作用到主贴图的UV上。

![](20200821172940944.gif)