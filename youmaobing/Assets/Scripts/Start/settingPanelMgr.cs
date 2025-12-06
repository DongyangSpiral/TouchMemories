using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settingPanelMgr : MonoBehaviour
{

    //音乐音效设置开关
    public Toggle musicT;
    public Toggle soundsT;

    //音乐音效滑条
    public Slider musicSlider;
    public Slider soundSlider;

    //public AudioClip audioClip;
    void Start()
    {
        //初始化音效滑条
        soundSlider.value = musicData.soundValue;
        //初始化音乐滑条
        musicSlider.value = musicData.musicValue;

        musicT.isOn = true;
        soundsT.isOn = true;
        musicT.onValueChanged.AddListener((v) =>
        {
            tsAudioPlay();
            musicsounds.mIsOpen(v);
            if (!v)
                musicSlider.value = 0;
            else musicSlider.value = 1;
        });
        soundsT.onValueChanged.AddListener((v) =>
        {
            tsAudioPlay();
            //musicsounds.soundsPlay();
            musicsounds.sIsOpen(v);
            if (!v)
                soundSlider.value = 0;
            else soundSlider.value = 1;
        });
        //监听音乐变化
        musicSlider.onValueChanged.AddListener((v) =>
        { 
            musicsounds.mChangeVaule(v);
        });
        //监听音效变化
        soundSlider.onValueChanged.AddListener((v) =>
        {         
            musicsounds.sChangeVaule(v);
        });
       
    }

    // Update is called once per frame
    void Update()
    {
        //musicsounds.playMusic();
        //musicsounds.soundsPlay();
        //Debug.Log($"Update函数中，musicData.isOpenBE: {musicData.isOpenBE}");
        if (!musicT.isOn)
        {
            musicsounds.playMusic();
        }
        //if (!soundsT.isOn)
        //{
        //    musicsounds.soundsPlay();
        //}
        //if (musicData.isOpenBE)
        //{
        //    musicsounds.playMusic();
        //    //Debug.Log($"{musicData.isOpenBE}");
        //}
        //else
        //{
        //    musicsounds.stopMusic();
        //}
        //if (musicData.isOpenSound)
        //{
        //    musicsounds.soundsPlay();
        //    //Debug.Log($"{musicData.isOpenSound}");
        //}
        //else
        //{
        //    musicsounds.soundStop();
        //}
    }
    private void tsAudioPlay()
    {
        //musicsounds.changeSoundAudioClip(audioClip);
        if (musicData.isOpenSound)
        {
            musicsounds.soundsPlay();
        }
    }
}
