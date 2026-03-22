using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class Dairy : MonoBehaviour
{
    private Flowchart Flowchart;
    public CameraScript MainC;
    public CameraScript DairyC;
    private void Start()
    {
        Flowchart = FindObjectOfType<Flowchart>();
    }
    private void OnMouseDown()
    {
        MainC.ChangeCamera(MainC,DairyC);
        Flowchart.ExecuteBlock("D1");
    }
}
