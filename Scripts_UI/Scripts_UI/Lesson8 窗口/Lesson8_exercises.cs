using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8_exercises : MonoBehaviour
{

    private static Lesson8_exercises instance;

    public static void ShowMe()
    {
        if (instance != null)
        {
            instance.gameObject.SetActive(true);
        }
    }
    public static void HideMe()
    {
        if (instance != null)
        {
            instance.gameObject.SetActive(false);
        }
    }
    public Rect rect5;
    public Rect rect6;
    private void Awake()
    {
        instance = this;
        HideMe();
    }
    private void OnGUI()
    {
        GUI.ModalWindow(1, new Rect(270, 100, 300, 200), Drawindow, "是否退出");
    }

    private void Drawindow(int id)
    {
        switch (id)
        {
            case 1:
                if (GUI.Button(rect5, "返回游戏"))
                {
                    HideMe ();
                    Lesson2_exericses.ShowMe();
                }
                if (GUI.Button(rect6, "退出游戏"))
                {
                    Application.Quit();
                }
                break;
        }
    }
}
