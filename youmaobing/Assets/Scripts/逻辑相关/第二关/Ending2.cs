using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class Ending2 : MonoBehaviour
{
    private SpriteRenderer sr;
    private Flowchart flowchart;
    private Change NowC;
    public List<SpriteRenderer> endings;
    void Start()
    {
        
        flowchart = FindObjectOfType<Flowchart>();

    }

    void Update()
    {
        if (flowchart.GetBooleanVariable("GoNext1"))
        {
            SpriteFader.Instance.Fade(endings[0], 0f, 0.3f);
        }
         if (flowchart.GetBooleanVariable("GoNext2"))
        {
            SpriteFader.Instance.Fade(endings[1], 0f, 0.3f);
        }
         if (flowchart.GetBooleanVariable("GoNext3"))
        {
            SpriteFader.Instance.Fade(endings[2], 0f, 0.3f);
        }
         if (flowchart.GetBooleanVariable("GoNext4"))
        {
            SpriteFader.Instance.Fade(endings[3], 0f, 0.3f);
        }

          if (flowchart.GetBooleanVariable("isEnd"))
        {
            scenseChangeMgr.ChangeScene(4);
            musicData.isOpenBE = false;
            musicData.nowScenseIndex = 4;
        }
    }


}
