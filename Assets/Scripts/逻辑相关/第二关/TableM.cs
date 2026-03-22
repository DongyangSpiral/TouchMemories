using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class TableM : MonoBehaviour
{
    public Change NowC;
    public Change TarC;
    private Flowchart flowchart;
    private void Start()
    {
        flowchart = FindObjectOfType<Flowchart>();
    }
    private void OnMouseDown()
    {
        if (flowchart.GetBooleanVariable("HasOKPaper"))
        {
            NowC.ChangeCamera(NowC, TarC);
            flowchart.ExecuteBlock("Mirror");
        }
    }
}
