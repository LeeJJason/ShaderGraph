using UnityEngine;

/// <summary>
/// 该脚本挂在要溶解的物体上
/// </summary>
public class Script5_21_1 : MonoBehaviour
{
    /// <summary>
    /// 材质球
    /// </summary>
    public Material mat;
    /// <summary>
    /// 要靠近过来的物体
    /// </summary>
    public Transform m_targetObj;



    // Update is called once per frame
    void Update()
    {
        if (mat.HasProperty("Vector3_B45F07CF"))
        {
            mat.SetVector("Vector3_B45F07CF", m_targetObj.position);
        }
    }
}