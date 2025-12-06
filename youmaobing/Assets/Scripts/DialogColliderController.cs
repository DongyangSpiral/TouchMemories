using UnityEngine;

public class DialogColliderController : MonoBehaviour
{
    // 拖入场景中的SayDialog游戏对象
    private GameObject sayDialog;

    // 存储所有碰撞体的原始状态
    private Collider2D[] allColliders;
    private bool[] originalStates;
    private bool lastState;

    private void Start()
    {
        sayDialog = GameObject.Find("SayDialog");
        print("1");
        // 初始化时获取所有碰撞体
        RefreshColliders();
        lastState = sayDialog != null && sayDialog.activeInHierarchy;
        UpdateColliders(lastState);
    }

    private void Update()
    {
        RefreshColliders();
        if (sayDialog == null) return;

        bool currentState = sayDialog.activeInHierarchy;
        if (currentState != lastState)
        {
            UpdateColliders(currentState);
            lastState = currentState;
        }
    }

    // 更新所有碰撞体状态
    private void UpdateColliders(bool dialogActive)
    {
        if (allColliders == null) return;

        for (int i = 0; i < allColliders.Length; i++)
        {
            if (allColliders[i] != null)
            {
                // 对话框激活时禁用碰撞体，否则恢复原始状态
                allColliders[i].enabled = dialogActive ? false : originalStates[i];
            }
        }
    }

    // 重新获取场景中的所有碰撞体
    private void RefreshColliders()
    {
        allColliders = FindObjectsOfType<Collider2D>();
        originalStates = new bool[allColliders.Length];

        for (int i = 0; i < allColliders.Length; i++)
        {
            if (allColliders[i] != null)
            {
                originalStates[i] = allColliders[i].enabled;
            }
        }
    }

    // 编辑器按钮，用于手动刷新碰撞体列表
    [ContextMenu("Refresh Colliders")]
    private void RefreshCollidersEditor()
    {
        RefreshColliders();
        Debug.Log($"已刷新碰撞体列表，共找到{allColliders.Length}个碰撞体");
    }
}