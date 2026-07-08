using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{
    public Rect Rect1;
    public Texture tex;
    private void OnGUI()
    {
        //一 图片绘制
        GUI.DrawTexture(Rect1, tex);

        //二 框绘制
        GUI.Box(Rect1, "123");
    }
}
