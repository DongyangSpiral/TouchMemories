using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ESCSetting : MonoBehaviour
{
    ////音乐音效设置开关
    //public Toggle musicT;
    //public Toggle soundsT;

    //音乐音效滑条
    public Slider musicSlider;
    public Slider soundSlider;

    // Start is called before the first frame update
    void Start()
    {
        //初始化音效滑条
        soundSlider.value = musicData.soundValue;
        //初始化音乐滑条
        musicSlider.value = musicData.musicValue;

        //musicT.isOn = true;
        //soundsT.isOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        //musicT.onValueChanged.AddListener((v) =>
        //{
        //    //tsAudioPlay();
        //    //musicsounds.mIsOpen(v);
        //    musicData .isOpenBE = v;
        //    if (!v)
        //        musicSlider.value = 0;
        //    else musicSlider.value = 1;
        //});

        //soundsT.onValueChanged.AddListener((v) => 
        //{
        //    musicData.isOpenSound = v; 
        //});
        //监听音乐变化
        musicSlider.onValueChanged.AddListener((v) =>
        {
            musicData.musicValue = v;
        });
        //监听音效变化
        soundSlider.onValueChanged.AddListener((v) =>
        {
            musicData.soundValue = v;
        });
    }
}
