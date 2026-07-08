using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    private int toolbarint = 0;
    private string[] toolvarstr = new string[] { "选择一", "选择二", "选择三", "选择四" };
    private int selint = 0;
    private void OnGUI()
    {
        //一 工具栏
        toolbarint = GUI.Toolbar(new Rect(0, 0, 300, 30), toolbarint,toolvarstr);
        switch (toolbarint)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
        }

        //二 选择网格
        //对比工具栏多一个参数 可以调整一个水平显示多少个按钮数量
        GUI.SelectionGrid(new Rect(0, 50, 200, 30), selint, toolvarstr,3);
    }
}
