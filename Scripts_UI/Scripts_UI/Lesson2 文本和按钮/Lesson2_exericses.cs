using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lesson2_exericses : MonoBehaviour
{
    //面板的显示隐藏 所有地方都能够快速使用的
    //静态 方法和变量 就可以直接通过类名使用
    private static Lesson2_exericses instance;

    public static void ShowMe()
    {
        if (instance != null)
        {
            instance.gameObject.SetActive(true);
        }
    }
    public static void HideMe()
    {
        if (instance != null)
        {
            instance.gameObject.SetActive(false);
        }
    }
    public Rect rect1;
    public Rect rect2;
    public Rect rect3;
    public Rect rect4;
    public Rect rect5;
    public Rect rect6;
    public GUIStyle sty1;
    public GUIStyle sty2;

    private void Awake()
    {
        instance = this;
    }
    private void OnGUI()
    {
        //游戏标题

        GUI.Label(rect1, "坦克迷宫" , sty1);

        if(GUI.Button(rect2, "开始游戏" , sty2))
        {
            Lesson4_execrises.ShowMe();
            HideMe();
        }

        if(GUI.Button(rect3, "游戏设置" , sty2))
        {
            Lesson3_execrises.ShowMe();
            HideMe();
        }

        if(GUI.Button(rect4, "退出游戏" , sty2))
        {
            Lesson8_exercises.ShowMe();
            HideMe();
        }

    }
    //总结
    //1.要完成 面板之间 相互控制显示 有3中方法
    //第一种:都写在一个onGUI中 通过boo1标识去控制显影第三种:挂载在不同对象上
    //通过控制对象的 失活激活 来达到 面板的显影
    //第二种:挂载在同一个对象上 通过控制脚本的失活激活 enable去控制代码是否执行 达到显复

    //2.关键的如何在多个面板之闸相互调用显影 我们是通过 静态变量和静态方法的形式在Awake时
    //初始化静态变量 如果要用该方法一开始 这个对象不能失活

}
