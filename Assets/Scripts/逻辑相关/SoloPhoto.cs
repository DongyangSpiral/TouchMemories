using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class SoloPhoto : MonoBehaviour
{

    public Wardrobe wardrobe;
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

        if(Hangup.sprite == ChestOn)
        {
            PhotoWall.ChangeCamera(PhotoWall, ChestWall);
        }

        if (wardrobe.HasOpened)
        {
            
            Hangup.sprite = ChestOn;

        }
        if(wardrobe.HasOpened == false)
        {
            flowchart.ExecuteBlock("SoloPhoto");
        }
    }
}
