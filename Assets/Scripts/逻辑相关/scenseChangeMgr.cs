using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenseChangeMgr : MonoBehaviour
{
   public static void ChangeScene(int index)
    {
        SceneManager.LoadScene (index);
    }
}
