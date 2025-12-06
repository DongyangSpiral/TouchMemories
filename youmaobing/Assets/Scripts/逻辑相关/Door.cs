using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private Flowchart flowchart;
    public PasswordLockManager passwordLockManager;
    private AudioSource audio;


    private void Start()
    {
        flowchart = FindObjectOfType<Flowchart>();
        audio = GetComponent<AudioSource>();
        audio.volume = musicData.musicValue;
        if (musicData.isOpenBE)
        {
            audio.Play();
        }
        else
        {
            audio.Stop();
        }
    }

    private void OnMouseDown()
    {
        flowchart.ExecuteBlock("Door");
        if (passwordLockManager.hasKey)
        {
            audio.Play();

        }

    }


}
