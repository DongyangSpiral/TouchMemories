using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{

    public void ChangeCamera(Change A, Change B)
    {
        bool Astate = A.gameObject.activeSelf;
        bool Bstate = B.gameObject.activeSelf;
        A.gameObject.SetActive(Bstate);
        B.gameObject.SetActive(Astate);
    }
}
