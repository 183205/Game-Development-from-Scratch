using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lesson4_execrises : MonoBehaviour
{
    private static Lesson4_execrises instance;

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
    private void Awake()
    {
        instance = this;
        HideMe();
    }

    private string zhanghao = "";
    private string mima= "";
    public Rect Rect1;
    public GUIStyle but;
    private void OnGUI()
    {
        GUI.Label(new Rect(340, 100, 50, 50), "账号");
        GUI.Label(new Rect(340, 170, 50, 50), "密码");
        zhanghao = GUI.TextField(new Rect(370, 100, 100, 50), zhanghao);
        mima = GUI.PasswordField(new Rect(370,170,100,50), mima,'*');

            if (zhanghao == "admin" && mima == "516416" && GUI.Button(new Rect(370, 240, 100, 50), "进入游戏"))
            {
                SceneManager.LoadScene("GameScene");
                HideMe();
            }else if(GUI.Button(new Rect(370, 240, 100, 50), "进入游戏"))
            {
                print("账号或密码错误");
            }
        
        

        if(GUI.Button(Rect1,"",but))
        {
            //关闭面板
            HideMe();
            Lesson2_exericses.ShowMe();
        }
    }
}
