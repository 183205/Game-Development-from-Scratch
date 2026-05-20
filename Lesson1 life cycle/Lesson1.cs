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
}
