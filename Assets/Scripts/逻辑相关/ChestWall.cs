using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestWall : MonoBehaviour
{
    public CameraScript ChestWallC;
    public CameraScript ChestC;

    private void OnMouseDown()
    {
        ChestWallC.ChangeCamera(ChestWallC, ChestC);
    }
}
