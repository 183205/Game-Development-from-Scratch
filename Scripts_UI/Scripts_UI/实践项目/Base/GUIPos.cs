using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum E_Alignment_Type
{
    up,
    down, 
    left, 
    right,
    center,
    Left_up,
    Left_down,
    Right_up,
    Right_down,
}

/// <summary>
/// 这个脚本用来计算位置信息
/// </summary>
/// 
[System.Serializable]
public class GUIPos
{
    //主要是处理控件位置
    //要完成分辨率自适应的计算

    //该位置信息 会用来返回给外部 用于绘制控件
    //需要进行计算
    private Rect Rpos = new Rect(0,0,100,100);

    //屏幕九宫格对齐方式
    public E_Alignment_Type screen_Alignment_Type = E_Alignment_Type.center;
    //控件九宫格对齐方式
    public E_Alignment_Type Control_Alignment_Type = E_Alignment_Type.center;
    //偏移位置
    public Vector2 pos;
    //宽高
    public float width = 100;
    public float height = 50;

    //用于计算的中心点 成员变量
    private Vector2 centerpos;

    //计算控件中心点偏移的方法
    private void CalcCenterPos()
    {
        switch (Control_Alignment_Type)
        {
            case E_Alignment_Type.up:
                centerpos.x = -width / 2;
                centerpos.y = 0;
                break;
            case E_Alignment_Type.down:
                centerpos.x = -width / 2;
                centerpos.y = -height;
                break;
            case E_Alignment_Type.left:
                centerpos.x = 0;
                centerpos.y = -height /2;
                break;
            case E_Alignment_Type.right:
                centerpos.x = -width;
                centerpos.y = -height / 2;
                break;
            case E_Alignment_Type.center:
                centerpos.x = -width /2;
                centerpos.y = -height / 2;
                break;
            case E_Alignment_Type.Left_up:
                centerpos.x = 0;
                centerpos.y = 0;
                break;
            case E_Alignment_Type.Left_down:
                centerpos.x = 0;
                centerpos.y = -height;
                break;
            case E_Alignment_Type.Right_up:
                centerpos.x = -width;
                centerpos.y = 0;
                break;
            case E_Alignment_Type.Right_down:
                centerpos.x = -width;
                centerpos.y = -height;
                break;
            default:
                break;
        }
    }

    //计算相对于屏幕的位置方法
    private void ScreenPos()
    {
        switch (screen_Alignment_Type)
        {
            case E_Alignment_Type.up:
                Rpos.x = Screen.width/2 + centerpos.x + pos.x;
                Rpos.y = 0 + centerpos.y + pos.y;
                break;
            case E_Alignment_Type.down:
                Rpos.x = Screen.width / 2 + centerpos.x + pos.x;
                Rpos.y = Screen.height +centerpos.y - pos.y; 
                break;
            case E_Alignment_Type.left:
                Rpos.x = 0 + centerpos.x + pos.x;
                Rpos.y = Screen.height/2 + centerpos.y + pos.y;
                break;
            case E_Alignment_Type.right:
                Rpos.x = Screen.width + centerpos.x - pos.x;
                Rpos.y = Screen.height/2 + centerpos.y + pos.y;
                break;
            case E_Alignment_Type.center:
                Rpos.x = Screen.width / 2 + centerpos.x + pos.x;
                Rpos.y = Screen.height / 2 + centerpos.y + pos.y;
                break;
            case E_Alignment_Type.Left_up:
                Rpos.x = 0 + centerpos.x + pos.x;
                Rpos.y = 0 + centerpos.y + pos.y;
                break;
            case E_Alignment_Type.Left_down:
                Rpos.x = 0 + centerpos.x + pos.x;
                Rpos.y = Screen.height + centerpos.y - pos.y;
                break;
            case E_Alignment_Type.Right_up:
                Rpos.x = Screen.width + centerpos.x - pos.x;
                Rpos.y = centerpos.y + pos.y;
                break;
            case E_Alignment_Type.Right_down:
                Rpos.x = Screen.width + centerpos.x - pos.x;
                Rpos.y = Screen.height + centerpos.y  - pos.y;
                break;
        }
    }
    public Rect Pos
    {
        get
        {
            //进行计算
            //计算中心点偏移
            CalcCenterPos();

            //计算屏幕点偏移
            ScreenPos();

            //宽和高
            Rpos.width = width; 
            Rpos.height = height;
            return Rpos;
        }
    }

}
