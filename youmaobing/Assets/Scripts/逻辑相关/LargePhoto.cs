using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class LargePhoto : MonoBehaviour
{
    public GameObject p2;
    //public bool isActive;
    //private void Start()
    //{
    //    bool isActive = p2.activeSelf;
    //}
    public bool isActive()
    {
        return p2.gameObject.activeSelf;
    }
}
