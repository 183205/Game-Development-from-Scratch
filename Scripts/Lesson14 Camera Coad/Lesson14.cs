using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lesson14 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //一 重要静态成员
        //获取摄像机
        //主摄像机的获取
        //需要场景上面有一个标签是主摄像机的摄像机
        print(Camera.main.name);

        //获取摄像机的数量
        print(Camera.allCamerasCount);

        //获得所有摄像机
        Camera[] allCameas = Camera.allCameras;
        print(allCameas.Length);

        //渲染相关的委托
        //摄像机剔除前处理的委托函数
        Camera.onPreCull += (c) =>
        {

        };

        //摄像机渲染之前的委托
        Camera.onPreRender += (c) =>
        {

        };

        //摄像机渲染后处理的委托
        Camera.onPostRender += (c) =>
        {

        };

        //二 重要成员
        //界面上的参数 都可以在Camera中获取到
        Camera.main.depth = 10; // 设置 主摄像机的 深度

        //世界坐标转屏幕坐标
        //X Y 对应的是在屏幕上显示的坐标 Z 是里摄像机的z有多远
        //一般用来做的就是头顶血条的功能 调整近大远小
        Vector3 v = Camera.main.WorldToScreenPoint(this.transform.position);
        print(v);

        //屏幕坐标转世界坐标
        print(Camera.main.ScreenToWorldPoint(Input.mousePosition));
         
    }

    // Update is called once per frame
    void Update()
    {
        //屏幕坐标转世界坐标
        //X Y 是世界坐标的信息 Z是你的物体在距离Camera多远的横截面上移动距离
        print(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }
}
