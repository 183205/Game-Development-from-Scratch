using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    //当对象被创建时 才会调用该函数
    private void Awake()
    {
        //在Unity中打印信息的两种方式
        //1.没有继承Mono的时候
        Debug.Log(123);
        Debug.Log("error");
        Debug.LogWarning("error");
        //2.继承了mono
        print("123345");
    }
    //对我们来说 想要当一个对象被激活时，进行一些逻辑处理 就可以写这个函数
    //当对象被激活时触发
    private void OnEnable()
    {
        print("OnEnable");  
    }
    //当第一次帧更新执行时触发和Awake时机不同 比Awake晚
    private void Start()
    {
        print("3");  
    }
    //主要用于物理更新
    //每一帧都执行 但是这里的帧和游戏帧不同 时间间隔可以设置更新速度
    private void FixedUpdate()
    {
        print("333");
    }
    //主要处理游戏核心逻辑更新的函数
    private void Update()
    {
        print("Update");
    }
    //一般是用来处理摄像机位置的相关更新
    private void LateUpdate()
    {
        print("LateUpdate");
    }
    //当对象失活时激活当前函数
    private void OnDisable()
    {
        print("OnDisable");
    }
    //当对象被删除时激活执行函数
    private void OnDestroy()
    {
        print("Ondestory");
    }
    
}
