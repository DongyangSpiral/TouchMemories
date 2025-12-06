using System.Collections;
using System.Collections.Generic;
using Fungus;
using Unity.VisualScripting;
using UnityEngine;

public class CodeBox : MonoBehaviour
{
    private Flowchart flowchart;
    private bool has1 = false;
    private bool has2 = false;
  

    public GameObject OpenFirst;
    public GameObject OpenSecond;
    public bool Check1 = true;
    public bool Check2 = true;

    public Change NowC;
    public Change TarCofPaper;
    public Change TarCofBigger;
    public GameObject SwapBtn;
    private void Start()
    {
        flowchart = FindObjectOfType<Flowchart>();
 
    }
    private void OnMouseDown()
    {
        if (flowchart.GetBooleanVariable("Has1Code") && has1 == false)
        {

            OpenFirst.SetActive(true);
            has1 = true;
        }
        if(flowchart.GetBooleanVariable("Has2Code") && has2 == false)
        {
           OpenSecond.SetActive(true);
            Check1 = false;
            has2 = true;
        }
        if (flowchart.GetBooleanVariable("Open1") && Check1)
        {
            NowC.ChangeCamera(NowC, TarCofPaper);
            
            flowchart.ExecuteBlock("GetPaper");
            SwapBtn.gameObject.SetActive(true);
        }
        if(flowchart.GetBooleanVariable("Open2") && Check2)
        {
            NowC.ChangeCamera(NowC, TarCofBigger);
            flowchart.ExecuteBlock("GetBigger");
        }
    }

}
