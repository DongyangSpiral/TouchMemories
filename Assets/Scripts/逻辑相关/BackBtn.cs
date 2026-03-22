using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackBtn : MonoBehaviour
{
    public GameObject LargerImage;
    public GameObject MainImage;
    public void OnMouseDown()
    {
        Debug.Log("Sprite 被点击！");
        // 在这里写点击逻辑（如播放音效、跳转场景等）
        LargerImage.SetActive(false);
        MainImage.SetActive(true);
    }
}
