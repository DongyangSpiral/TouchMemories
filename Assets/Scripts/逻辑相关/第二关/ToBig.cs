using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class ToBig : MonoBehaviour
{
    private Flowchart flowchart;
    public GameObject Big;
    void Start()
    {
        flowchart = FindAnyObjectByType<Flowchart>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flowchart.GetBooleanVariable("OKToBig"))
        {
            Big.SetActive(true);
        }
    }
}
