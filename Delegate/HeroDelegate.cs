using UnityEngine;

public class HeroDelegate : MonoBehaviour
{
    //Hero HP <=0
    public delegate void HeroDie();//发布委托并定义委托类型，类型名HeroDie.//可以写在命名空间下，方便引用
}
