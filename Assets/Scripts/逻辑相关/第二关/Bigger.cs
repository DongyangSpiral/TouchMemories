using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bigger : MonoBehaviour
{
    public Change NowC;
    public Change TarC;

    private void OnMouseDown()
    {
        NowC.ChangeCamera(NowC, TarC);
    }
}
