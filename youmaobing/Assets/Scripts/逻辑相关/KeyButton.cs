using UnityEngine;

public class KeyButton : MonoBehaviour
{
    public enum ButtonType { Digit, Confirm, Reset }
    public ButtonType buttonType = ButtonType.Digit;

    [Header("For Digit Buttons")]
    public string digitValue;  // 设置数字值 (0-9)

    private NewPassword lockManager;
    private PasswordLockManager passwordLockManager;
    void Start()
    {
        lockManager = FindObjectOfType<NewPassword>();
        if (lockManager == null) { 
        passwordLockManager = FindObjectOfType<PasswordLockManager>();
        }
    }

    void OnMouseDown()
    {
        if (lockManager == null)
        {

            switch (buttonType)
            {
                case ButtonType.Digit:
                    passwordLockManager.AddDigit(digitValue);
                    break;
                case ButtonType.Confirm:
                    passwordLockManager.ConfirmInput();
                    break;
                case ButtonType.Reset:
                    passwordLockManager.ResetInput();
                    break;
            }

            // 按钮动画
            transform.localScale = Vector3.one * 0.8f;
            Invoke("ResetButton", 0.1f);
        }
        if(passwordLockManager == null)
        {
            switch (buttonType)
            {
                case ButtonType.Digit:
                    lockManager.AddDigit(digitValue);
                    break;
                case ButtonType.Confirm:
                    lockManager.ConfirmInput();
                    break;
                case ButtonType.Reset:
                    lockManager.ResetInput();
                    break;
            }

            // 按钮动画
            transform.localScale = Vector3.one * 0.8f;
            Invoke("ResetButton", 0.1f);
        }
    }
    void ResetButton()
    {
        transform.localScale = Vector3.one;
    }
}