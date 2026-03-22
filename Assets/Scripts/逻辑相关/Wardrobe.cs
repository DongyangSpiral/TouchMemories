using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wardrobe : MonoBehaviour
{

    public bool HasKey = false;
    public bool HasOpened = false;
    public CameraScript Main;
    public CameraScript WardrobeC;

    private void OnMouseDown()
    {
        Main.ChangeCamera(Main, WardrobeC);
    }

}
