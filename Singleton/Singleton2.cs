using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 单例实现方式2，继承自MonoBehaviour
/// 用处用来生成一个物体且只生成一个
/// </summary>
public class Singleton2 : MonoBehaviour
{
    //题外话：值得一提的是，这里用的是单例的懒汉模式，这种实现方式的线程是不安全的，如果是在服务器端的高并发情况下极其容易使单例类被实例化两次
    private static Singleton2 _Instance;
    // private static readonly object obj = new object();
    public static Singleton2 Instance
    {
        get
        {
            // if (_Instance == null)                      ///////////
            // {                                           /题外话：双重枷锁，改进了懒汉模式
            //     lock (obj);                             //////////
                if (_Instance==null)
                {
                    GameObject objGameObject = new GameObject("New Only GameObjet");
                    _Instance = objGameObject.AddComponent<Singleton2>();
                    DontDestroyOnLoad(objGameObject);
                }
            // }
            return _Instance;
        }
    }
    public void TextLog() => Debug.Log("我执行了Singleton2单例化方法，实例化了");
}
