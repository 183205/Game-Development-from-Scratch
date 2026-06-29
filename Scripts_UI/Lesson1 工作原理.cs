using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1工作原理 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //一 GUI是什么
        //全称 即时模式游戏用户交互界面
        //在Unity中一般简称为GUI 他是一个代码驱动的UI系统

        //二 GUI的主要作用
        //1.作为程序员的调试工具 创建游戏内调试工具
        //2.为脚本组件创建自定义检视面板
        //3.创建新的编辑器窗口和工具 以拓展Unity本身(一般用作内置游戏工具)
        
        //不要用它为玩家制作UI功能

    }

    //三 GUI的工作原理
    //调用GUI提供的方法
    //类似生命周期函数
    private void OnGUI()
    {
        //在其中书写 GUI相关代码 即可显示GUI内容
    }
    //1.它每帧执行 相当于是用于专门绘制GuI界面的函数
    //2.一般只在其中执行GUI相关界面绘制和操作逻辑
    //3.该函数在 onDisable之前 Lateupdate之后执行
    //4.只要是继承Mono的脚本 都可以在onGUI中绘制GUI



    // Update is called once per frame
    void Update()
    {
        
    }
}
