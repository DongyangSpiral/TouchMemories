using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatableObject : MonoBehaviour
{
    public float targetAngle = 90f; // 每次点击旋转的角度


    private void OnMouseDown() // 需确保物体有Collider2D
    {
        float newAngle = targetAngle;
        StartCoroutine(SmoothRotate(newAngle, 0.5f)); // 平滑旋转
      
    }

    IEnumerator SmoothRotate(float angle, float duration)
    {
        Quaternion startRot = transform.rotation;
        Quaternion endRot = startRot * Quaternion.Euler(0, 0, angle); // 绕Z轴旋转
        float t = 0;
        while (t < duration)
        {
            t += Time.deltaTime;
            transform.rotation = Quaternion.Slerp(startRot, endRot, t / duration);
            yield return null;
        }
    }
}