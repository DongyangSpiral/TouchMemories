using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESC : MonoBehaviour
{
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if(!panel.activeSelf)
                panel.SetActive(true);
            else 
                panel.SetActive(false);
        }
        //if (Input.GetKeyUp(KeyCode.Escape) && panel.activeSelf)
        //{
        //    panel.SetActive(false);
        //}
    }
}
