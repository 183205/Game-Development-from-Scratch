using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7 : MonoBehaviour
{
    public Rect BegRect;
    public Rect scpos;
    public Rect scrpos;
    private Vector2 vs;
    private void OnGUI()
    {
        //一 分组
        //用于批量控制控件位置
        //可以理解为 包裹着的控件加了一个父对象
        //可以通过控制分组来控制包裹控件的位置
        GUI.BeginGroup(BegRect);
        GUI.Button(new Rect(0,0,100,50),"测试按键");
        GUI.Button(new Rect(0, 30, 100, 50), "测试按键");
        GUI.EndGroup();

        //二 滚动列表
        vs = GUI.BeginScrollView(scpos,vs,scrpos);
        GUI.Button(new Rect(0, 0, 100, 50), "测试按键");
        GUI.Button(new Rect(0, 30, 100, 50), "测试按键");
        GUI.Button(new Rect(0, 40, 100, 50), "测试按键");
        GUI.Button(new Rect(0, 70, 100, 50), "测试按键");
        GUI.Button(new Rect(0, 80, 100, 50), "测试按键");
        GUI.Button(new Rect(0, 110, 100, 50), "测试按键");
        GUI.Button(new Rect(0, 90, 100, 50), "测试按键");
        GUI.Button(new Rect(0, 120, 100, 50), "测试按键");
        GUI.Button(new Rect(0, 100, 100, 50), "测试按键");
        GUI.Button(new Rect(0, 150, 100, 50), "测试按键");
        GUI.Button(new Rect(0, 110, 100, 50), "测试按键");
        GUI.Button(new Rect(0, 180, 100, 50), "测试按键");
        GUI.EndScrollView();
    }
}
