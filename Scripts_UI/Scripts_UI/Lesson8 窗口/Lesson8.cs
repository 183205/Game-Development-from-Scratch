using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8 : MonoBehaviour
{
    public Rect windowpos;
    private void OnGUI()
    {
        //一 窗口
        //第一个参数id 是窗口唯一id 不能重复
        //第二个是位置
        //第三个是传入一个委托函数
        GUI.Window(1, new Rect(100, 100, 200, 150),Drawindow,"测试窗口");
        //id对于我们来说 有一个重要作用 可以区分不同窗口 还可以在一个函数里处理多个窗口
        //通过id区分
        GUI.Window(2, new Rect(100, 100, 200, 150), Drawindow, "测试窗口2");

        //模态窗口
        //模态窗口 可以让该其它控件不在有用
        //你可以理解该窗口在最上层 其它按钮都点击不到了
        //只能点击该窗口上控件
        GUI.ModalWindow(3, new Rect(100, 100, 200, 150), Drawindow, "模态窗口");

        //拖动窗口
        //位置赋值只是前提 需要使用api
        windowpos = GUI.Window(4, windowpos, Drawindow, "拖动窗口");

    }
    private void Drawindow (int id)
    {
        switch(id)
        {
            case 1:
                GUI.Button(new Rect(0, 0, 100, 100), "牛的");
                break;
            case 3:
                GUI.Button(new Rect(0, 0, 100, 100), "牛的");
                break;
            case 4:
                //需要用到DragWindow方法
                //参数是设置能够拖动的位置 默认是都可以拖动 也可以设置位置
                GUI.DragWindow(new Rect(0,0,200,20));
                break;

        }    
    }
}
