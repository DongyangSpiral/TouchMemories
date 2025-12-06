using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraScript : MonoBehaviour
{
    [Header("移动设置")]
    public float panSpeed = 5f;
    public float edgeThreshold = 10f;

    [Header("可视区域边界")]
    public Vector2 minVisibleBoundary = new Vector2(-10, -10);
    public Vector2 maxVisibleBoundary = new Vector2(10, 10);

    private Camera mainCamera;
    private float cameraHalfHeight;
    private float cameraHalfWidth;

    void Start()
    {
        mainCamera = GetComponent<Camera>();
        CalculateCameraDimensions();
    }

    void Update()
    {
        Vector3 moveDirection = GetMoveDirection();
        MoveCamera(moveDirection);
    }

    // 计算摄像机视口尺寸
    void CalculateCameraDimensions()
    {
        if (mainCamera.orthographic)
        {
            cameraHalfHeight = mainCamera.orthographicSize;
            cameraHalfWidth = cameraHalfHeight * mainCamera.aspect;
        }
        else
        {
            // 透视摄像机需要不同的计算
            float distance = Mathf.Abs(transform.position.z);
            cameraHalfHeight = Mathf.Tan(mainCamera.fieldOfView * 0.5f * Mathf.Deg2Rad) * distance;
            cameraHalfWidth = cameraHalfHeight * mainCamera.aspect;
        }
    }

    // 检测鼠标位置并返回移动方向
    Vector3 GetMoveDirection()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 direction = Vector3.zero;

        if (mousePos.x <= edgeThreshold) direction.x -= 1;
        if (mousePos.x >= Screen.width - edgeThreshold) direction.x += 1;

        // 不处理Y轴
        return direction.normalized;
    }

    // 移动摄像机并确保视口不超出边界
    // 移动摄像机并确保视口不超出边界（仅X轴）
    void MoveCamera(Vector3 direction)
    {
        // 计算目标位置
        Vector3 targetPosition = transform.position + new Vector3(direction.x, 0, 0) * panSpeed * Time.deltaTime;

        // 只限制X轴
        targetPosition.x = Mathf.Clamp(
            targetPosition.x,
            minVisibleBoundary.x + cameraHalfWidth,
            maxVisibleBoundary.x - cameraHalfWidth
        );

        // Y轴保持不变
        targetPosition.y = transform.position.y;

        transform.position = targetPosition;
    }

    // 可视化边界（在Scene视图中显示）
    void OnDrawGizmosSelected()
    {
        // 绘制可视区域边界
        Gizmos.color = Color.green;
        Vector3 center = (minVisibleBoundary + maxVisibleBoundary) * 0.5f;
        Vector3 size = new Vector3(
            maxVisibleBoundary.x - minVisibleBoundary.x,
            maxVisibleBoundary.y - minVisibleBoundary.y,
            0.1f
        );
        Gizmos.DrawWireCube(center, size);

        // 绘制当前摄像机视口边界
        if (Application.isPlaying)
        {
            Gizmos.color = Color.cyan;
            Vector3 cameraMin = new Vector3(
                transform.position.x - cameraHalfWidth,
                transform.position.y - cameraHalfHeight,
                transform.position.z
            );
            Vector3 cameraMax = new Vector3(
                transform.position.x + cameraHalfWidth,
                transform.position.y + cameraHalfHeight,
                transform.position.z
            );
            Vector3 cameraCenter = (cameraMin + cameraMax) * 0.5f;
            Vector3 cameraSize = new Vector3(
                cameraMax.x - cameraMin.x,
                cameraMax.y - cameraMin.y,
                0.1f
            );
            Gizmos.DrawWireCube(cameraCenter, cameraSize);
        }
    }
    
    public void ChangeCamera(CameraScript A,CameraScript B)
    {
        bool Astate = A.gameObject.activeSelf;
        bool Bstate = B.gameObject.activeSelf;
        A.gameObject.SetActive(Bstate);
        B.gameObject.SetActive(Astate);
    }
}