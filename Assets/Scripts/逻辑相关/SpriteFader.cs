using UnityEngine;

public class SpriteFader : MonoBehaviour
{
    // 单例实例
    private static SpriteFader _instance;
    public static SpriteFader Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<SpriteFader>();
                if (_instance == null)
                {
                    GameObject obj = new GameObject("SpriteFader");
                    _instance = obj.AddComponent<SpriteFader>();
                    DontDestroyOnLoad(obj); // 可选：跨场景不销毁
                }
            }
            return _instance;
        }
    }

    private SpriteRenderer _targetSprite;
    private float _targetAlpha;
    private float _fadeSpeed;
    private bool _isFading;

    private void Update()
    {
        if (!_isFading || _targetSprite == null) return;

        // 计算新透明度
        Color color = _targetSprite.color;
        color.a = Mathf.MoveTowards(color.a, _targetAlpha, _fadeSpeed * Time.deltaTime);
        _targetSprite.color = color;

        // 检查是否完成
        if (Mathf.Approximately(color.a, _targetAlpha))
        {
            _isFading = false;
        }
    }

    /// <summary>
    /// 让 Sprite 渐变为目标透明度
    /// </summary>
    /// <param name="sprite">目标 SpriteRenderer</param>
    /// <param name="targetAlpha">透明度 (0~1)</param>
    /// <param name="duration">持续时间（秒）</param>
    public void Fade(SpriteRenderer sprite, float targetAlpha, float duration)
    {
        if (sprite == null) return;

        _targetSprite = sprite;
        _targetAlpha = Mathf.Clamp01(targetAlpha);
        _fadeSpeed = Mathf.Abs(sprite.color.a - _targetAlpha) / duration; // 计算速度
        _isFading = true;
    }

    /// <summary>
    /// 立即设置 Sprite 透明度（跳过渐变）
    /// </summary>
    public void SetAlphaImmediately(SpriteRenderer sprite, float alpha)
    {
        if (sprite == null) return;

        Color color = sprite.color;
        color.a = Mathf.Clamp01(alpha);
        sprite.color = color;
        _isFading = false; // 停止正在进行的渐变
    }
}