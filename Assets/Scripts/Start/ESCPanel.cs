using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ESCPanel : MonoBehaviour
{
    public GameObject panel;
    public Button btn1;
    public Button btn2;
    // Start is called before the first frame update
    void Start()
    {
        if (panel == null)
        { 
            panel = GetComponent<GameObject>(); 
        }
        panel.SetActive(false);

        if (btn1 != null)
        {
            btn1.onClick.AddListener(() =>
            {
                panel.SetActive(false );
            });
        }
        if (btn2 != null)
        {
            btn2.onClick.AddListener(() =>
            {
              Application.Quit();
            });
        }
    }


}
