using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class Photo : MonoBehaviour
{
    public CameraScript Main;
    public CameraScript PhotoWall;
    private Flowchart flowchart;
    private void Start()
    {
        flowchart = FindObjectOfType<Flowchart>();
    }

    private void OnMouseDown()
    {
        Main.ChangeCamera(Main, PhotoWall);
        flowchart.ExecuteBlock("Photo");
    }
}
