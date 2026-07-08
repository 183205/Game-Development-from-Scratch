using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    private string inputstr = " ";
    private string inputstrmm = " ";
    private float avs = 0;
    private float bvs = 0;
    private void OnGUI()
    {
        //一 输入框
        //普通输入
        //参数一 位置 参数二 内容 参数三 最大字符串长度
        inputstr = GUI.TextField(new Rect(0, 0, 100, 50), inputstr,5);

        //密码输入
        inputstrmm = GUI.PasswordField(new Rect(0, 100, 100, 50), inputstrmm, '*');

        //二 拖动条
        //水平拖动条
        avs = GUI.HorizontalSlider(new Rect(0, 200, 100, 50), avs, 0, 100);
        Debug.Log(avs);

        //竖直拖动条
        bvs = GUI.VerticalSlider(new Rect(0,250, 100, 50), bvs, 0, 100);
        Debug.Log(bvs);

    }
}
