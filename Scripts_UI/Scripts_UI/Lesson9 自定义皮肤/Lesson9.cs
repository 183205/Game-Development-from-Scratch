using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson9 : MonoBehaviour
{
    private void OnGUI()
    {
        // 一 全局颜色
        //全局的着色颜色 影响背景和文本颜色 自定义的style也会受影响
        //全局颜色和单个的设置都会进行相乘
        GUI.color = Color.yellow;

        //文本颜色
        GUI.contentColor = Color.yellow; 

        //背景颜色
        GUI.backgroundColor = Color.yellow;

        GUI.Button(new Rect(0, 0, 100, 30), "测试按钮");
        GUI.Label(new Rect(0, 0, 100, 30), "测试标签");

        //二 整体皮肤样式
        //可以创建一个skin文件 综合所有控件的皮肤
        //方便直接使用
        GUI.skin = null;

        GUI.Button(new Rect(0, 0, 100, 30), "测试按钮");
    }
}
