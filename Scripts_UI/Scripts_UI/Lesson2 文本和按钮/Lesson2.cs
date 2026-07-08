using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    public Texture tex;
    public Rect Rect;
    public Rect Rect1;
    public GUIContent content;
    public GUIStyle GUIStyle;
    public Rect ButtonRect;
    public GUIContent ButtonCont;
    public GUIStyle Buttonsty;
    private void OnGUI()
    {
        //一 GUI 控件绘制的共同点
        //1.他们都是GUI公共类中提供的静态函数 直接调用即可
        //2.他们的参数都大同小异
        //位置参数:Rect参数 x y 位置 w h 尺寸
        //显示文本:string参数
        //图片信息:Texture参数
        //综合信息:GUIcontent参数
        //自定义样式:GuIStyle参数
        //3.每一种控件都有多种重载，都是各个参数的排列组合
        //必备的参数内容 是 位置信息和显示信息

        //二 文本控件
        //基本使用
        GUI.Label(new Rect(0,0,100,20),"学习真好");
        GUI.Label(Rect,tex);

        //综合使用
        GUI.Label(Rect1, content);
        //自定义样式
        GUI.Label(new Rect(0, 0, 100, 20), "学习真好", GUIStyle);

        //三 按钮控件
        //综合使用
        //GUI.Button(ButtonRect, ButtonCont);

        //if(GUI.Button(ButtonRect, ButtonCont))
        //{
        //    Debug.Log("1");
        //}

        if (GUI.RepeatButton(ButtonRect, ButtonCont))
        {
            Debug.Log("2");
        }

    }
}
