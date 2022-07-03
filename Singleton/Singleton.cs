using System.Collections;
using UnityEngine;


/// <summary>
/// 单例实现方式1（普通类），没有继承自MonoBehaviour
/// 
/// </summary>
public class Singleton
{
    private static Singleton _Instance;

    public static Singleton Instance
    {
        get
        {
            if (_Instance == null)
            {
                _Instance = new Singleton ();
                Debug.Log("get里实例化了Singleton ");
            }
            return _Instance;
        }

    }
//-------------------------------------拥有的两个协程方法--------------------------------------------
    public  IEnumerator Test1()
    {
        yield return 0;//表示下一帧执行后面操作
        Debug.Log(Time.frameCount+"帧了，现在显示我哦！");
        yield return new WaitForSeconds(10f);//使用scaled time延迟执行之后的语句
        Debug.Log(Time.time+"秒后的现在终于显示我啦！");
        // yield return Test1();//可以让协程死循环
        yield return Test2();//可以跳到Test2协程中
        
    }

    public IEnumerator Test2()
    {
        Debug.Log("开启Test1()协程结束开启Test2()了。");
        yield return new WaitForSecondsRealtime(10f);//使用unscaled time延迟执行之后的语句
        Debug.Log("10秒过去了，现在再次开启Text1()。");
        yield return Test1();//可以又跳回Test1协程
    }
}
