using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveBtn : MonoBehaviour
{
    public CameraScript Main;
    public CameraScript Other;
    public GameObject MainScene;

    void OnMouseDown()
    {
        Debug.Log("Sprite ±»µã»÷£¡");
        Main.ChangeCamera(Main, Other);
        MainScene.SetActive(true);
    }
}
