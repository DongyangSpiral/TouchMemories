using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class Table : MonoBehaviour
{
    public Change NowC;
    public Change TableC;

    private void OnMouseDown()
    {
        NowC.ChangeCamera(NowC, TableC);
    }
}
