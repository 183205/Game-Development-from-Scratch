using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    private bool isSel;
    public GUIStyle sty;

    private int nowSelIndex = 1;
    private void OnGUI()
    {
        //一 多选框
        //普通样式
        //isSel = GUI.Toggle(new Rect(0, 0, 100, 50), isSel, "效果开关");
        //自定义样式
        //修改固定宽高 fixedWidth和fixedHeight
        //修改从GUIStyle 边缘到内容起始处的空间 padding
        isSel = GUI.Toggle(new Rect(0, 0, 100, 50), isSel, "效果开关",sty);

        //二 单选框
        //单选框是基于多选框的实现
        //通过一个int标识来决定是否选中
        if (GUI.Toggle(new Rect(0, 0, 100, 50), nowSelIndex == 1, "选择1"))
        {
            nowSelIndex = 1;
        }
        if (GUI.Toggle(new Rect(0, 100, 100, 50), nowSelIndex == 2, "选择2"))
        {
            nowSelIndex = 2;
        }
        if (GUI.Toggle(new Rect(0, 200, 100, 50), nowSelIndex == 3, "选择3"))
        {
            nowSelIndex = 3;
        }

    }
}
