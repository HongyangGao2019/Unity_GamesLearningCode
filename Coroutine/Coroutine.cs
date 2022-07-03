using System.Collections;
using UnityEngine;

/// <summary>
///协程部分示例
///部分用处：可以延迟传递信息，例如可以在协程中定义一个延迟时间，使得伤害信息在技能特效动作时间结束后结算，达到同步效果
/// </summary>
public class Coroutine : MonoBehaviour
{
    private int num=0;
    public IEnumerator Test1()
    {
        yield return 0;//下一帧执行后续操作
        Debug.Log("一帧结束，开启协程Test1()了");
        yield return new WaitForFixedUpdate();//Waits until next fixed frame rate update function.
        Debug.Log("next fixed frame over了");
    }

    public IEnumerator Test2(int x, int y)
    {
        yield return new WaitForSeconds(2f);//scaled time
        num = x * y;
        Debug.Log(num);
        yield return new WaitForSecondsRealtime(10f);//unscaled time
        Debug.Log("时间已经过去"+Mathf.Round(Time.time)+"了");
    }

    public void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            StartCoroutine(Test1());
        }

        if (Input.GetKeyDown("b"))
        {
            StartCoroutine(Test2(3,7)); 
        }

        if (Input.GetKeyDown("c"))
        {
            // StopCoroutine(Test1());
            // StopCoroutine(Test2());
            StopAllCoroutines();
        }
    }
}
