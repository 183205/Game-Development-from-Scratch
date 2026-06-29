using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson16 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //一 物理碰撞检测响应函数
    //碰撞触发接触时 自动执行这个函数
    private void OnCollisionEnter(Collision collision)
    {
        //Collision 里面 包含了 碰到自己的对象的相关信息
        //1.碰撞到的对象碰撞器的信息
        //collision.collider


        //2.碰撞对象的依附对象（Game Object）
        //collision.gameObject

        //3.碰撞对象的依附对象的位置信息
        //collision.transform

        //4.碰撞点数相关
        //collision.contactCount;
        //接触点 具体坐标
        //ContactPoint[] pso = collision.contacts;

        //只要得到了 碰撞到的对象的 任意一个信息 就可以得到全部信息

        print(this.name + "被" + collision.gameObject.name + "撞到了");
    }
    //碰撞结束分离时 会自动执行的函数
    private void OnCollisionExit(Collision collision)
    {
        print(this.name + "被" + collision.gameObject.name + "结束碰撞了");
    }
    //两个物体相互接触摩擦时 会不停的调用该函数
    private void OnCollisionStay(Collision collision)
    {
        print(this.name + "一直在和" + collision.gameObject.name + "接触");
    }

    //二 触发器检测响应函数
    //触发开始的函数 当第一次接触时 会自动调用
    private void OnTriggerEnter(Collider other)
    {
        print(this.name + "被" + other.gameObject.name + "触发了");
    }

    //触发结束的函数 当接触状态结束后触发 会调用一次
    private void OnTriggerExit(Collider other)
    {
        print(this.name + "和" + other.gameObject.name + "结束触发了");
    }

    //当两个对象 接触时会不停触发
    private void OnTriggerStay(Collider other)
    {
        print(this.name + "一直在和" + other.gameObject.name + "触发");
    }

    //三 要明确什么时候会响应函数
    //只要挂载的对象 能和别的物体产生碰撞或者触发 那么对于的响应函数就会触发

    //四 碰撞和触发器函数都可以写成虚函数 在子类去重写逻辑
    //一般会把想要重回写的 碰撞和触发函数 写成保护类型的 没有必要写成public 因为不会自己手动调用
    //都是unity 通过反射帮助我们自动生成的
}
