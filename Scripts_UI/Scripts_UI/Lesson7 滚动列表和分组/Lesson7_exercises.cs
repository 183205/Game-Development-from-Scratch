using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7_exercises : MonoBehaviour
{
    public Rect svRect;
    public Rect showRect;
    private Vector2 nowRect;

    public string[] str;
    private void OnGUI()
    {
        //通过字符串数组动态修改内部的尺寸
        showRect.height = str.Length * 30;

        nowRect = GUI.BeginScrollView(svRect, nowRect, showRect);
        for (int i = 0; i < str.Length; i++)
        {
            GUI.Label(new Rect(0, i * 30, 100, 50), str[i]);
        }

        GUI.EndScrollView();
    }

}
