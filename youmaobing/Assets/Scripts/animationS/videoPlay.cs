using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videoPlay : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject gameObject;

    private AudioSource  audioSource;
    private void Awake()
    {
        if (gameObject == null)
        gameObject = GetComponent<GameObject>();
        if (videoPlayer.GetComponent<AudioSource>() == null)
        {
            audioSource = videoPlayer.gameObject.AddComponent<AudioSource>();
        }
        else
        {
            audioSource = videoPlayer.GetComponent<AudioSource>();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if (videoPlayer == null)
        {
            videoPlayer = GetComponent<VideoPlayer>();
        }

        audioSource .volume =musicData.musicValue;
        if(!musicData.isOpenBE)
        {
            audioSource.volume = 0;
        }

        videoPlayer.source = VideoSource.VideoClip;
        audioSource.volume=musicData.musicValue-0.2f;
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += OnPrepareCompleted;
        //videoPlayer.Play();
        videoPlayer.loopPointReached += OnVideoFinished;
    }

    private void OnVideoFinished(VideoPlayer source)
    {
        gameObject.SetActive(false);
        scenseChangeMgr.ChangeScene(0);
        musicData.nowScenseIndex = 0;
    }

    private void OnPrepareCompleted(VideoPlayer source)
    {
        videoPlayer.Play();
    }

}
