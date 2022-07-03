using System;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private HeroDelegate.HeroDie heroDelegate;//创建委托

    private void Update()
    {
        if (Input.GetKeyDown("y"))
        {
            //委托实例是可以对同一方法多次订阅的，但我们这儿并不想重复订阅，所以先检验是否为null，为null再进行订阅
            if (heroDelegate == null)
            {
                Debug.Log("heroDelegate委托实例化了（订阅了***）");
                heroDelegate += MasterWin;
            }
        }
        if (Input.GetKeyDown("n"))
        {
            Debug.Log("我Disable了");
            heroDelegate -= MasterWin;
        }
        if (Input.GetKeyDown("a"))
        {
            heroDelegate();
        }
    }

    // public void OnEnable()
    // {
    //     //委托的实例化
    //     Debug.Log("委托实例化了，订阅了***");
    //     heroDelegate += MasterWin;//+=和=是有区别的，+=为了防止内存泄露还需要-=来取消订阅，=会执行清零并赋值最后一次赋值的方法，event没有=
    // }
    
    // public void OnDisable()
    // {
    //     Debug.Log("我Disable了");
    //     heroDelegate -= MasterWin;
    // }
    
    //声明具有与委托相同签名的方法1
    public void MasterWin()
    {
        Debug.Log("We monsters win!");
    }
}
