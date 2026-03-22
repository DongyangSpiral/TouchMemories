// PianoKey.cs - 附加到每个琴键对象上
using UnityEngine;

public class PianoKey : MonoBehaviour
{
    public string noteName; // 音符名称 (如 "C4", "D4", "E4" 等)
    public AudioClip sound; // 对应的音效
    public Piano pianoManager;

    void Start()
    {

    }

    void OnMouseDown()
    {
        PlayNote();
    }

    public void PlayNote()
    {
        // 播放音效
        if (sound != null)
            AudioSource.PlayClipAtPoint(sound, transform.position);

        // 通知钢琴管理器记录音符
        if (pianoManager != null)
            pianoManager.AddPlayedNote(noteName);
    }
}