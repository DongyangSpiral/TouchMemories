using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNextBtn : MonoBehaviour
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
        Diary.currentIndex++;
        if (Diary.currentIndex >= Diary.diarySprites.Count)
        {
            Diary.currentIndex = Diary.diarySprites.Count - 1; // 确保索引不超过列表长度
        }
        audio.Play();
        Diary.nowPage.sprite = Diary.diarySprites[Diary.currentIndex]; // 更新当前显示的日记图片
    }
}
