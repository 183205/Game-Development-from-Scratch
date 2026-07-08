using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6_exercises : MonoBehaviour
{
    public Rect toolRect;
    public Rect selRect;
    public Rect labRect;
    
    private int index;
    private string[] toolstr = new string[4] {"编辑","项目","调试","工具" };
    
    private void OnGUI()
    {
        index = GUI.Toolbar(toolRect, index,toolstr);
        index = GUI.SelectionGrid(selRect, index,toolstr,1);

        switch(index)
        {
            case 0:
                GUI.Label(labRect,"复制");
                break;
            case 1:
                GUI.Label(labRect, "添加类");
                break;
            case 2:
                GUI.Label(labRect, "开始");
                break;
            case 3:
                GUI.Label(labRect, "选项");
                break;
        }    
    }
}
