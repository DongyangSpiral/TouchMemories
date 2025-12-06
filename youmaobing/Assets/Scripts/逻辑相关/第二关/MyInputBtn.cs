using System.Collections;
using System.Collections.Generic;
using Fungus;
using Unity.VisualScripting;
using UnityEngine;

public class MyInputBtn : MonoBehaviour
{
    public SpriteRenderer CodeBox;
    public Sprite OpenBox;
    private Flowchart flowchart;
    private string BlockName;
    private AudioSource audioSource;
    private void Start()
    {
        flowchart = FindObjectOfType<Flowchart>();
        BlockName = this.gameObject.name;
        audioSource = GetComponent<AudioSource>();
    }
    private void OnMouseDown()
    {
        CodeBox.sprite = OpenBox;
        audioSource.Play();
        flowchart.ExecuteBlock(BlockName);
        Invoke("Die", 1.0f);
    }
    private void Die()
    {
        this.gameObject.SetActive(false);
    }
}
