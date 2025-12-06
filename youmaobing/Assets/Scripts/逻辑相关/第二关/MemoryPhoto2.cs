using Fungus;
using UnityEngine;

public class MemoryPhoto2 : MonoBehaviour
{

    private Flowchart flowchart;

    private void Start()
    {
        flowchart = FindObjectOfType<Flowchart>();
    }

    private void OnMouseDown()
    {
     ;
        flowchart.ExecuteBlock("MemoryPhoto");


    }
}
