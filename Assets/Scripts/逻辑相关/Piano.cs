using UnityEngine;
using System.Collections.Generic;
using Fungus;

public class Piano : MonoBehaviour
{
    // 基础配置
    public Flowchart flowchart;
    public SpriteRenderer locked;
    public Sprite unlock;
    public Wardrobe wardrobe;
    public CameraScript MainC;
    public CameraScript PianoC;

    // 演奏系统
    [Header("Piano Settings")]
    public string[] correctSequence = { "C4", "D4", "E4", "F4", "G4", "A4", "B4", "C5" }; // 正确音符序列
    private List<string> playedNotes = new List<string>(); // 玩家演奏的音符

    // 重置参数
    [SerializeField] private float resetDelay = 0f; // 错误后重置延迟
    private bool isChecking = true;



    private void OnMouseDown()
    {
        MainC.ChangeCamera(MainC, PianoC);
    }
    private void Update()
    {
        // 调试用键盘快捷键
        if (Input.GetKeyDown(KeyCode.X)) CheckSequence();
    }

    // 添加演奏的音符
    public void AddPlayedNote(string note)
    {
        if (!isChecking) return;

        playedNotes.Add(note);

        // 达到序列长度时检查
        if (playedNotes.Count >= correctSequence.Length)
        {
            CheckSequence();
        }
    }

    // 检查序列是否正确
    private void CheckSequence()
    {
        bool correct = true;

        // 比较每个音符
        for (int i = 0; i < correctSequence.Length; i++)
        {
            if (i >= playedNotes.Count || playedNotes[i] != correctSequence[i])
            {
                correct = false;
                break;
            }
        }

        if (correct)
        {
            OnCorrectSequence();
        }
        else
        {
            StartCoroutine(ResetSequence());
        }
    }

    // 正确演奏的处理
    private void OnCorrectSequence()
    {
        isChecking = false;

        // 更新锁的图片
        if (locked != null && unlock != null)
            locked.sprite = unlock;

        // 触发对话
        if (flowchart != null)
            flowchart.ExecuteBlock("Correctlyplaying");

        // 给予钥匙
        
            wardrobe.HasKey = true;
    }

    // 重置演奏序列
    private System.Collections.IEnumerator ResetSequence()
    {
        isChecking = false;
        yield return new WaitForSeconds(resetDelay);
        playedNotes.Clear();
        isChecking = true;
    }
}