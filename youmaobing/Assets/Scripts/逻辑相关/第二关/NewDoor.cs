using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class NewDoor : MonoBehaviour
{
    private Flowchart flowchart;
    public NewPassword passwordLockManager;
    private AudioSource audio;
    public Change NowC;
    public Change TarC;

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
            NowC.ChangeCamera(NowC,TarC);
            flowchart.ExecuteBlock("Ending1");
        }

    }


}