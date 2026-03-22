using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class Ending : MonoBehaviour
{

    private Flowchart flowchart;
    public Change NowC;
    public Change EndingC;
    public SpriteRenderer AskSprite;
    public SpriteRenderer SmileSprite;
    public SpriteRenderer CrySprite;
    private bool ok1 = false;
    private bool ok2 = false;
    private void Start()
    {
        flowchart = FindObjectOfType<Flowchart>();
    }
    void Update()
    {
        if (flowchart.GetBooleanVariable("DoorOpen") && !EndingC.gameObject.activeSelf && ok1 == false)
        {
            SpriteFader.Instance.Fade(AskSprite, 1.0f,1f);
            NowC.ChangeCamera(NowC, EndingC);
            flowchart.ExecuteBlock("Ending");
            ok1 = true;
        }
        if (flowchart.GetBooleanVariable("DauSmile") && ok2 == false)
        {
            SpriteFader.Instance.SetAlphaImmediately(SmileSprite, 1f);
            SpriteFader.Instance.Fade(AskSprite, 0f, 0.3f);
            ok2 = true;
         
        }
        if (flowchart.GetBooleanVariable("DauCry"))
        {
           
            SpriteFader.Instance.SetAlphaImmediately(CrySprite, 1f);
            SpriteFader.Instance.Fade(SmileSprite, 0f, 0.3f);


        }
        if (flowchart.GetBooleanVariable("GoToOther"))
        {
            scenseChangeMgr.ChangeScene(3);
            musicData.nowScenseIndex = 3;
        }
    }
}
