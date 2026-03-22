using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class BrithPhoto : MonoBehaviour
{
    private Flowchart flowchart;

    private void Start()
    {
        flowchart = FindObjectOfType<Flowchart>();
    }
    private void OnMouseDown()
    {
        flowchart.ExecuteBlock("BirthPhoto");
    }
}
