using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCase : MonoBehaviour
{
    public CameraScript NowC;
    public CameraScript OpenCaseC;

    private void OnMouseDown()
    {
        NowC.ChangeCamera(NowC, OpenCaseC);
    }
}
