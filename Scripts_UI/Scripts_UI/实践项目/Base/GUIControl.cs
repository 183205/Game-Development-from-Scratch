using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum E_Style_Open
{ 
    on,
    off,
}


public abstract class GUIControl : MonoBehaviour
{
    //提取控件的共同表现
    //位置信息
    public GUIPos guiPos;

    //显示内容信息
    public GUIContent content;

    //自定义信息
    public GUIStyle style;
    //自定义样式是否启用开关
    public E_Style_Open style_Open = E_Style_Open.off;

    //提供给外部
    public void GrawGui()
    {
        switch (style_Open)
        {
            case E_Style_Open.on:
                StyleOn();
                break;
            case E_Style_Open.off:
                StyleOff();
                break;
            default:
                break;
        }
    }
    protected abstract void StyleOn();

    protected abstract void StyleOff();

}
