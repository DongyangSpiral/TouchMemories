using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapPhoto : MonoBehaviour
{
    public GameObject yes;
    public GameObject no;

    public void Swap()
    {
        bool Astate = yes.gameObject.activeSelf;
        bool Bstate = no.gameObject.activeSelf;
        yes.gameObject.SetActive(Bstate);
        no.gameObject.SetActive(Astate);
    }
}
