using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DLastBtn : MonoBehaviour
{
    public DiaryReading Diary;
    private AudioSource audio;
    private void Start()
    {
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
         
         Diary.currentIndex--;
        if (Diary.currentIndex < 0)
        {
            Diary.currentIndex = 0; // 确保索引不小于0
        }
        audio.Play();
        Diary.nowPage.sprite = Diary.diarySprites[Diary.currentIndex]; // 更新当前显示的日记图片
    }
}
