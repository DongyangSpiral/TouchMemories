using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class SoloPhoto2 : MonoBehaviour
{

 
    public CameraScript PhotoWall;
    public CameraScript ChestWall;
    public SpriteRenderer Hangup;
    public Sprite ChestOn;
    private Flowchart flowchart;

    private void Start()
    {
        flowchart = FindObjectOfType<Flowchart>();
    }

    private void OnMouseDown()
    {

        if (Hangup.sprite == ChestOn)
        {
            PhotoWall.ChangeCamera(PhotoWall, ChestWall);
        }

        if (flowchart.GetBooleanVariable("OKToDown"))
        {

            Hangup.sprite = ChestOn;

        }
        if (flowchart.GetBooleanVariable("OKToDown") == false)
        {
            flowchart.ExecuteBlock("SoloPhoto");
        }
    }
}