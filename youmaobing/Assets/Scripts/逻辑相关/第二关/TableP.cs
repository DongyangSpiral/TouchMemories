using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class TableP : MonoBehaviour
{

    public Change NowC;
    public Change TarC;
    private void OnMouseDown()
    {
        NowC.ChangeCamera(NowC,TarC);
    }

}
