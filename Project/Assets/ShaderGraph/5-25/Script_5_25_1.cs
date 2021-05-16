
using UnityEngine;
using UnityEngine.EventSystems;


/// <summary>
/// �ι���UI
/// </summary>
public class Script_5_25_1 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    /// <summary>
    /// ���Ƶ�Ŀ��ͼƬ
    /// </summary>
    public RenderTexture renderTexture;
    /// <summary>
    /// ��ˢ
    /// </summary>
    public Texture brushTexture;

    /// <summary>
    /// �հ�ͼ
    /// </summary>
    public Texture blankTexture;

    /// <summary>
    /// mask��RectTransform
    /// </summary>
    public RectTransform rectTransform;
    /// <summary>
    /// ����
    /// </summary>
    public Canvas canvas;

    private bool m_isMove = false;

    private void Start()
    {
        DrawBlank();
    }

    /// <summary>
    /// ��ʼ��RenderTexture
    /// </summary>
    private void DrawBlank()
    {
        // ����rt
        RenderTexture.active = renderTexture;
        // ���浱ǰ״̬
        GL.PushMatrix();
        // ���þ���
        GL.LoadPixelMatrix(0, renderTexture.width, renderTexture.height, 0);

        // ������ͼ
        Rect rect = new Rect(0, 0, renderTexture.width, renderTexture.height);
        Graphics.DrawTexture(rect, blankTexture);

        // �����ı�
        GL.PopMatrix();

        RenderTexture.active = null;
    }

    /// <summary>
    /// ��RenderTexture��(x,y)���괦����ˢͼ��
    /// </summary>
    /// <param name="x">Graphics����ϵ�µ�x</param>
    /// <param name="y">Graphics����ϵ�µ�y</param>
    private void Draw(int x, int y)
    {
        // ����rt
        RenderTexture.active = renderTexture;
        // ���浱ǰ״̬
        GL.PushMatrix();
        // ���þ���
        GL.LoadPixelMatrix(0, renderTexture.width, renderTexture.height, 0);


        // ���Ʊ�ˢͼ��
        x -= (int)(brushTexture.width * 0.5f);
        y -= (int)(brushTexture.height * 0.5f);
        Rect rect = new Rect(x, y, brushTexture.width, brushTexture.height);
        Graphics.DrawTexture(rect, brushTexture);

        // �����ı�
        GL.PopMatrix();

        RenderTexture.active = null;
    }

    /// <summary>
    /// ����
    /// </summary>
    public void OnPointerDown(PointerEventData data)
    {
        m_isMove = true;
    }

    /// <summary>
    /// ̧��
    /// </summary>
    public void OnPointerUp(PointerEventData data)
    {
        m_isMove = false;
    }

    private void Update()
    {
        if (m_isMove)
        {
            OnMouseMove(Input.mousePosition);
        }
    }

    /// <summary>
    /// �ο�
    /// </summary>
    /// <param name="position">�ο�����Ļ����</param>
    private void OnMouseMove(Vector2 position)
    {
        // ��ȡ�ε�λ�õ�ui�ֲ�����
        var uiLocalPos = ScreenPosToUiLocalPos(position, rectTransform, canvas.worldCamera);
        // ���ֲ�����ת��Ϊuv����
        var uvX = (rectTransform.sizeDelta.x / 2f + uiLocalPos.x) / rectTransform.sizeDelta.x;
        var uvY = (rectTransform.sizeDelta.y / 2f + uiLocalPos.y) / rectTransform.sizeDelta.y;
        // ��uv����ת��ΪGraphics����
        var x = (int)(uvX * renderTexture.width);
        // ע�⣬uv����ϵ��Graphics����ϵ��y�᷽���෴
        var y = (int)(renderTexture.height - uvY * renderTexture.height);

        Draw(x, y);
    }

    /// <summary>
    /// ����Ļ����ץ��ΪĿ��RectTransform�ľֲ�����
    /// </summary>
    /// <param name="screenPos">��Ļ����</param>
    /// <param name="transform">Ŀ��RectTransform</param>
    /// <param name="cam">�����</param>
    /// <returns>ui�ֲ�����</returns>
    private Vector2 ScreenPosToUiLocalPos(Vector3 screenPos, RectTransform transform, Camera cam)
    {
        Vector2 uiLocalPos;

        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(transform, screenPos, cam, out uiLocalPos))
        {
            return uiLocalPos;
        }
        return Vector2.zero;
    }
}
