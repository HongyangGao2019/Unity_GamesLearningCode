using UnityEngine;

/// <summary>
/// 单例实现方式三，这样实现单例很简单，但只能存在场景中的唯一一个物体上
/// </summary>
public class Singleton3 : MonoBehaviour
{
    public static Singleton3 Instance;

    void Awake()
    {
        Instance = this;
    }
}
