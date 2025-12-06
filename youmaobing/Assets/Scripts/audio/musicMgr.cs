using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicMgr : MonoBehaviour
{
    public AudioSource backgroudMusic;
    public AudioClip clip;
    private void Awake()
    {
        GameObject gameObject = this.gameObject;
        if (clip!=null)
        {
            backgroudMusic.clip = clip;
            backgroudMusic.loop = true;
        }
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
       
        if(musicData.isOpenBE)
        {
            backgroudMusic.Play();
        }
        else
        {
            backgroudMusic.Stop();
        }
        gameObject.SetActive(true);
        backgroudMusic.Play();
    }
    private void Update()
    {
        backgroudMusic.volume = musicData.musicValue;
        if (musicData.nowScenseIndex==0)
        {
            gameObject.SetActive(true);
        }
        if (musicData.nowScenseIndex==4) 
        {
            gameObject.SetActive(false);
        }
    }
}
