using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchableObject : MonoBehaviour
{
    public bool isTouchable;
    private void Start()
    {
        isTouchable = false;
    }
    public void SetTouchable(bool touchable)
    {
        isTouchable = touchable;
    }
}
