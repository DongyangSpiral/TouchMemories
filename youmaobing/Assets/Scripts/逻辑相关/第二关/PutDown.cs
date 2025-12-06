using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutDown : MonoBehaviour
{
    public SpriteRenderer sr;
    private Transform father;
    public Sprite newSp;
    private Collider2D collider;
    private void Start()
    {
        father = this.gameObject.transform.parent;
        collider = father.gameObject.GetComponent<Collider2D>();
    }
    private void OnMouseDown()
    {
        sr.sprite = newSp;
        
    }
}
