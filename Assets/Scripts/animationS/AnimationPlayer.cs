using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationPlayer : MonoBehaviour
{
    private Animation animation;
    public string animationName;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animation>();
        if (animation == null)
        {
            return;
        }
        animation.Play("animationName");
        StartCoroutine(WaitForAnimationToEnd());
    }

    public IEnumerator WaitForAnimationToEnd()
    {
        // 等待动画播放完成
        yield return new WaitForSeconds(animation[animationName].length);
        // 切换场景
        scenseChangeMgr.ChangeScene(2);
    }
 
}
