using Fungus;
using UnityEngine;
using UnityEngine.UI;

public class NewPassword : MonoBehaviour
{
    [Header("Settings")]
    public int passwordLength = 4;  // 密码长度
    public Text displayText;        // 显示文本的UI Text

    [Header("Sound Effects")]
    public AudioClip keyPressSound;
    public AudioClip correctSound;
    public AudioClip wrongSound;

    private string currentInput = "";
    private AudioSource audioSource;


    public SpriteRenderer Locked;
    public Sprite Unlocked;
    private Flowchart flowchart;
    public CameraScript nowC;
    public bool hasKey = false;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        flowchart = FindObjectOfType<Flowchart>();
        UpdateDisplay();
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
    private void Update()
    {
        if (!nowC.gameObject.activeSelf)
        {
            displayText.text = "";
            currentInput = "";
        }
    }
    // 添加数字到当前输入
    public void AddDigit(string digit)
    {
        if (currentInput.Length >= passwordLength) return;

        currentInput += digit;
        PlaySound(keyPressSound);
        UpdateDisplay();
    }

    // 重置输入
    public void ResetInput()
    {
        currentInput = "";
        PlaySound(keyPressSound);
        UpdateDisplay();
    }

    // 确认密码
    public void ConfirmInput()
    {
        PlaySound(keyPressSound);
        bool isCorrect = LockController.ValidatePassword2(currentInput);

        if (isCorrect)
        {
            PlaySound(correctSound);
            displayText.gameObject.gameObject.SetActive(false); // 隐藏显示文本
            // 密码正确逻辑由你实现
            LockController.OnCorrectPassword();
            Locked.sprite = Unlocked;
            flowchart.ExecuteBlock("OpenChest");
            hasKey = true;
        }
        else
        {
            PlaySound(wrongSound);
            ResetInput();
        }
    }

    private void UpdateDisplay()
    {
        if (displayText != null)
        {
            // 显示星号代替实际数字
            displayText.text = new string('*', currentInput.Length);
        }
    }

    private void PlaySound(AudioClip clip)
    {
        if (audioSource != null && clip != null)
        {
            audioSource.clip = clip;
            audioSource.PlayOneShot(clip);
        }
    }
}