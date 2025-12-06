using System.Collections;
using System.Collections.Generic;
using Fungus;
using Unity.VisualScripting;
using UnityEngine;

public class DiaryReading : MonoBehaviour
{
    public List<Sprite> diarySprites; // 存储日记图片的列表
    public int currentIndex = 0; // 当前显示的日记图片索引
    public SpriteRenderer nowPage; // 用于显示日记图片的SpriteRenderer
    public DNextBtn DNextBtn; // 下一页按钮脚本
    public DLastBtn DLastBtn; // 上一页按钮脚本
    private Flowchart flowchart;
    public bool say = true;
    private bool once = false;
    private bool once2 = false;
    private void Start()
    {
        flowchart = FindObjectOfType<Flowchart>();
    }
    private void Update()
    {
        if (currentIndex == 0)
        {
            DLastBtn.gameObject.SetActive(false);

        }
        else
        {
            DLastBtn.gameObject.SetActive(true);
        }
        if (currentIndex == diarySprites.Count - 1)
        {
            DNextBtn.gameObject.SetActive(false);
            if(say)
            flowchart.ExecuteBlock("D2");
            say = false;
        }
        else
        {
            DNextBtn.gameObject.SetActive(true);
        }

        if (diarySprites[currentIndex].name == "日记试剂" && !once)
        {
            flowchart.ExecuteBlock("T1");
            once = true; // 确保只执行一次
        }
      
        if (diarySprites[currentIndex].name == "日记镜子" && !once2)
        {
            flowchart.ExecuteBlock("T2");
            once2 = true;
        }
    }

}
