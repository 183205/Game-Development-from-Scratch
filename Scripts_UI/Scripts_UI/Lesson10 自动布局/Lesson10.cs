using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour
{

    private void OnGUI()
    {
        // 一 GUILayout 自动布局
        //主要用于编辑器的开发 不能设置位置
        //水平设置
        GUILayout.BeginHorizontal();

        GUILayout.Button("1");
        GUILayout.Button("123");
        GUILayout.Button("123456789");

        GUILayout.EndHorizontal();

        // 二 GUILayoutOption 布局选项

        //控件的固定宽高
        GUILayout.Width(300); 
        GUILayout.Height(200);
        //允许控件的最小宽高
        GUILayout.MinWidth(50);
        GUILayout.MinHeight(50);
        //允许控件的最大宽高
        GUILayout.MaxWidth(100);
        GUILayout.MaxHeight(100);
        //允许或禁止水平拓展
        GUILayout.ExpandWidth(true);//允许
        GUILayout.ExpandHeight(false);//禁止
        GUILayout.ExpandHeight(true);//允许
        GUILayout.ExpandHeight(false);//禁止
    }
}
