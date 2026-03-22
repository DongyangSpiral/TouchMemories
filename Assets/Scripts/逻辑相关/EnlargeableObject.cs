using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnlargeableObject : MonoBehaviour
{
    public GameObject LargerImage;
    
    public void Enlarge()
    {
        LargerImage.SetActive(true);
    }

    
}

