using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class WardrobeDrawer : MonoBehaviour
{
    private Flowchart flowchart;
    public Wardrobe wardrobe;
    public SpriteRenderer locked;
    public Sprite unlocked;
    public AudioClip clip;
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
        flowchart.ExecuteBlock("WardrobeDrawer");
        if (wardrobe.HasKey)
        {
            locked.sprite = unlocked;
            audio.clip = clip;
            audio.Play();
            wardrobe.HasOpened = true;
        }
    }
}
