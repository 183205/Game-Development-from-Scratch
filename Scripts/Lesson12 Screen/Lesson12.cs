using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //一 静态属性

        //常用
        //获取屏幕分辨率
        print(Screen.currentResolution);

        //屏幕当前窗口宽高
        //这个是得到当前屏幕的宽和高 一般使用的是这个
        print(Screen.width);//宽
        print(Screen.height);//高

        //屏幕休眠模式
        Screen.sleepTimeout = SleepTimeout.SystemSetting;

        //不常用
        //运行时是否是全屏模式
        Screen.fullScreen = true;

        //窗口模式类型 四种
        //独占全屏
        //全屏模式
        //最大窗口化
        //窗口模式
        Screen.fullScreenMode = FullScreenMode.FullScreenWindow;

        //二 静态方法
        //设置分辨率
        Screen.SetResolution(1920, 1680, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
