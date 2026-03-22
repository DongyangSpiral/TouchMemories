using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseMgr : MonoBehaviour
{
    public Texture2D  mouseSprite;

    // Start is called before the first frame update
    void Start()
    {
        //将鼠标锁定在屏幕内，测试可以不加
        //Cursor.lockState = CursorLockMode.Confined;
        //更改鼠标图
        Cursor.SetCursor(mouseSprite, Vector2.zero, CursorMode.Auto);

    }
    
}
