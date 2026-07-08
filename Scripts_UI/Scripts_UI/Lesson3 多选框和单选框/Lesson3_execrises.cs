using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Lesson3_execrises : MonoBehaviour
{
    //面板的显示隐藏 所有地方都能够快速使用的
    //静态 方法和变量 就可以直接通过类名使用
    private static Lesson3_execrises instance;

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
    public Rect Rect1;
    public Rect Rect2;
    public Rect Rect3;
    private bool isSel1;
    private bool isSel2;
    public GUIStyle but;
    private float avs;

    private void Awake()
    {
        instance = this;
        HideMe();
    }
    private void OnGUI()
    {
        isSel1 = GUI.Toggle(Rect1, isSel1, "背景音乐");
        avs = GUI.HorizontalSlider(new Rect(370, 170, 100, 50), avs, 0, 100);
        isSel2 = GUI.Toggle(Rect2, isSel2, "游戏音乐");
        if(GUI.Button(Rect3,"",but))
        {
            //关闭面板
            HideMe();
            Lesson2_exericses.ShowMe();
        }
    }
}
