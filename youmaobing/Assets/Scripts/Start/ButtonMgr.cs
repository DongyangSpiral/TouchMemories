using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonMgr : MonoBehaviour
{
    //按钮
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button surebtn;
    public Button exitbtn;
    //面板
    GameObject settingpanel;
    GameObject informationpanel;
    GameObject gameObject;
    //场景索引
    public  int SceneIndex = 0;
    //按键音效片段
    public AudioClip audioClip;
    AudioSource audioSource;
    //private void Awake()
    //{
    //    gameObject = GameObject.Find("sounds");
    //    if (gameObject != null)
    //    {
    //        audioSource = gameObject.GetComponent<AudioSource>();
    //        audioSource.clip = audioClip;
    //    }
    //}
    private void Start()
    {
        //得到面板
        settingpanel = GameObject.Find("settingPanel");
        if (settingpanel != null )
            settingpanel.SetActive(false);
        informationpanel = GameObject.Find("informationPanel");
        if (informationpanel != null )
            informationpanel.SetActive(false);
        //切换场景
        if (btn1 != null)
        {
            btn1.onClick.AddListener(() =>
            {
                SceneManager.LoadScene(SceneIndex);
                btnAudioPlay();
            });
        }
        //打开设置
        if (btn2 != null)
        {
            btn2.onClick.AddListener(() =>
            {
                if (!settingpanel.activeSelf)
                {
                    settingpanel.SetActive(true);
                    //audioSource.Play();
                }
                btnAudioPlay();
            });
        }
        //退出游戏
        if (btn3 != null)
        {
            btn3.onClick.AddListener(() =>
            {
                Application.Quit();
                btnAudioPlay();
            });
        }
        //信息面板打开
        if(btn4 != null)
        {
            btn4.onClick.AddListener(() =>
            {
                if (!informationpanel.activeSelf)
                {
                    informationpanel.SetActive(true);
                }
                btnAudioPlay();
            });
        }
        //设置面板确认后退出
        if (surebtn != null)
        {
            surebtn.onClick.AddListener(() =>
            {
                if (settingpanel.activeSelf)
                {
                    settingpanel.SetActive(false);
                }
                btnAudioPlay();
            });
        }
        //信息面板退出
        if(exitbtn != null)
        {
            exitbtn.onClick.AddListener(() =>
            {
               if (informationpanel.activeSelf)
               {
                   informationpanel.SetActive(false);
               }
               btnAudioPlay();
            });
        }
    }
    private void btnAudioPlay()
    {
        musicsounds.changeSoundAudioClip(audioClip);
        if (musicData.isOpenSound)
        {
            musicsounds.soundsPlay();
        }
    }
}
