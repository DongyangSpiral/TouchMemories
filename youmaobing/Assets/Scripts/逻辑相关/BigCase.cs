using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCase : MonoBehaviour
{
    public CameraScript NowC;
    public CameraScript BigCaseC;

    private void OnMouseDown()
    {
        NowC.ChangeCamera(NowC, BigCaseC);
    }
}
