using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14_exercises : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //练习一 把一个物体的世界坐标系的位置 转换成屏幕坐标 并打印出来
        print(Camera.main.WorldToScreenPoint(this.transform.position));

        //练习二 在屏幕上点击一下鼠标 在对应的世界坐标上生成一个cube出来
        //

    }

    // Update is called once per frame
    void Update()
    {
        //练习二 在屏幕上点击一下鼠标 在对应的世界坐标上生成一个cube出来

        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 v = Input.mousePosition;
            v.z = 20;
            obj.transform.position = Camera.main.ScreenToWorldPoint(v);
        }
    }
}
