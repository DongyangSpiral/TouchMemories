using System.Collections;
using System.Collections.Generic;
using Fungus;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class MemoryPhoto : MonoBehaviour
{
    public GameObject TruePhoto;
    public GameObject FalsePhoto;
    private Flowchart flowchart;
    public CameraScript NowC;
    public CameraScript MemoryPhotoC;
    private void Start()
    {
        flowchart = FindObjectOfType<Flowchart>();
    }

    private void OnMouseDown()
    {
        TruePhoto.SetActive(true);
        flowchart.ExecuteBlock("MemoryPhoto");
      
        NowC.ChangeCamera(NowC, MemoryPhotoC);
            
    }
}
