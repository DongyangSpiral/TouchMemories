using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class Paper : MonoBehaviour
{
    private Flowchart flowchart;
    public CameraScript NowC;
    public CameraScript PaperC;
    private void Start()
    {
        flowchart = FindObjectOfType<Flowchart>();

    }

    private void OnMouseDown()
    {
        NowC.ChangeCamera(NowC, PaperC);
        flowchart.ExecuteBlock("Paper");
    }
}
