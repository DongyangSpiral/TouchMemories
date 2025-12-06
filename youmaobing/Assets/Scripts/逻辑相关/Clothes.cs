using System.Collections;
using System.Collections.Generic;
using Fungus;
using Unity.VisualScripting;
using UnityEngine;

public class Clothes : MonoBehaviour
{
    private Flowchart flowchart;
    public CameraScript NowC;
    public CameraScript ClothesC;

    private void Start()
    {
        flowchart = FindObjectOfType<Flowchart>();

    }

    private void OnMouseDown()
    {
        NowC.ChangeCamera(NowC, ClothesC);
        flowchart.ExecuteBlock("Clothes");
    }
}
