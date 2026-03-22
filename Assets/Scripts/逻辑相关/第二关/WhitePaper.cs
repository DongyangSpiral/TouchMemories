using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class WhitePaper : MonoBehaviour
{
    private SpriteRenderer sr;
    private Flowchart flowchart;
    private AudioSource audioSource;
    private bool has = false;
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        flowchart = FindObjectOfType<Flowchart>();
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = musicData.musicValue;
        if (musicData.isOpenBE)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Stop();
        }
    }
    private void OnMouseDown()
    {
        flowchart.ExecuteBlock("WhitePaper");
        if (flowchart.GetBooleanVariable("HasPenping") && !has)
        {
            audioSource.Play();
            SpriteFader.Instance.Fade(sr, 0f, 1f);
            has = true;
        }
    }
}
