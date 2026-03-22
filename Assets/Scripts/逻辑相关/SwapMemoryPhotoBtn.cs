using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class SwapMemoryPhotoBtn : MonoBehaviour
{

    public GameObject TruePhoto;
    public GameObject FalsePhoto;
    public Flowchart flowchart;

    private void Start()
    {
        flowchart = FindObjectOfType<Flowchart>();
    }

    private void OnMouseDown()
    {
        TruePhoto.SetActive(false);
        FalsePhoto.SetActive(true);
        
    }
}
