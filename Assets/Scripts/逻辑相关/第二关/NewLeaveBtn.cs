using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLeaveBtn : MonoBehaviour
{
    public Change NowC;
    public Change BackTo;

    void OnMouseDown()
    {
        Debug.Log("Sprite ±»µã»÷£¡");
        NowC.ChangeCamera(NowC, BackTo);

    }
}

