using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class LockController
{
    // 设置正确密码 (在代码中修改)
    private const string CORRECT_PASSWORD1 = "0721";
    private const string CORRECT_PASSWORD2 = "5413";

    public static bool ValidatePassword1(string input)
    {
        return input == CORRECT_PASSWORD1;
    }
    public static bool ValidatePassword2(string input)
    {
        return input == CORRECT_PASSWORD2;
    }
    // 当密码正确时执行
    public static void OnCorrectPassword()
    {
        Debug.Log("对了");
    }
}