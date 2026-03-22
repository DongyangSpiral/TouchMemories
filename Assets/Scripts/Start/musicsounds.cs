using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicsounds : MonoBehaviour
{
    public AudioSource music;
    public AudioSource sound;
    //ÒôÀÖÒôÐ§Æ¬¶Î
    public AudioClip musicClip;
    public AudioClip soundsClip;

    private static musicsounds instance;
    public static musicsounds Instance { get => instance; }
    private void Awake()
    {
        instance = this;
        //DontDestroyOnLoad(this);
    }
    private void Update()
    {
        music.volume = musicData.musicValue;
        sound.volume = musicData.soundValue;
    }
    public static void playMusic()
    {
        instance.music.clip = instance.musicClip ;
        instance.music.loop = true;
        //if (musicData.isOpenBE)
            instance.music.Play();
    }

    public static void soundsPlay()
    {
       instance.sound.clip =instance.soundsClip ;
        //if (musicData.isOpenSound)
            instance.sound.Play();
    }
    public static void stopMusic()
    {
        instance.music.Stop();
    }
    public static void soundStop()
    {
        instance.sound.Stop();
    }
    public static void mChangeVaule(float v)
    {
        musicData.musicValue = v;
    }

    public static void sChangeVaule(float v)
    {
        musicData.soundValue = v;
    }

    public static void changeSoundAudioClip(AudioClip clip)
    {
        instance.sound.clip = clip;
    }
    public static void mIsOpen(bool v)
    {
        musicData.isOpenBE = v;
    }
    public static void sIsOpen(bool v)
    {
        musicData.isOpenSound = v;
    }
}
