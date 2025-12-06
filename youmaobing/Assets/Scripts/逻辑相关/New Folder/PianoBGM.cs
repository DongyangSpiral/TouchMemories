using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoBGM : MonoBehaviour
{


    private void OnEnable()
    {
        musicData.musicValue = 0.1f;
     
        print("PianoBGM enabled, musicValue set to 0.1f");
    }
    private void OnDisable()
    {
        musicData.musicValue = 0.6f;
      
    }
}
