using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lesson11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //输入相关内容都是在UPdate里面

        //一 返回鼠标在屏幕的位置
        //鼠标坐标的原点 在 屏幕左下角 往右是x轴正方向 往上是y轴正方向
        //Vector3 返回值只有x y 
        //print(Input.mousePosition);

        //二 检测鼠标的输入
        //0左键 1右键 2中键
        //鼠标按下的一瞬间 进入一次
        if(Input.GetMouseButtonDown(0) )
        {
            print("鼠标某一个建按下了");
        }

        //鼠标抬起一瞬间 进入一次
        if (Input.GetMouseButtonUp(1))
        {
            print("鼠标某一个建抬起了");
        }

        //鼠标长按按下抬起都会进入
        if (Input.GetMouseButton(1))
        {
            print("鼠标在被使用");
        }

        //检查中间滚动
        //返回值的 y -1下 0没有滚 1上
        print(Input.mouseScrollDelta) ;

        
        //三 检测键盘输入

        //键盘按下
        if (Input.GetKeyDown(KeyCode.W) )
        {
            print("按下w");
        }

        //传入字符串的重载
        //这里只能传入小写字母 不能大写
        if(Input.GetKeyDown("s"))
        {
            print("按下s");
        }

        //检查键盘抬起
        if(Input.GetKeyUp(KeyCode.W))
        {
            print("抬起w");
        }

        //检查键盘长按
        if(Input.GetKey(KeyCode.W))
        {
            print("w被按下");
        }

        //四 检测默认轴的输入
        //我们学习 鼠标 键盘 主要是用来 控制玩家 比如 旋转 位移等等
        //为了方便我们更好的控制 unity提供了一些方法

        //键盘AD按下时 返回 -1到1之间的变换
        print(Input.GetAxis("Horizontal"));

        //键盘SW按下时 返回 -1到1之间的变换
        print(Input.GetAxis("Vertical"));

        //鼠标横向移动时 -1 到 1 左右
        print(Input.GetAxis("Mouse X"));

        //鼠标竖向移动时 -1 到 1 上 下
        print(Input.GetAxis("Mouse Y"));

        //GetAxisRaw方法 和 GetAxis使用方式相同

        //只不过 他的返回值 只会是 -1 0 1 不会有中间值

        //五 其他了解知识

        //是否有任意键或鼠标长按
        if(Input.anyKey)
        {
            print("有一个键按下");
        }

        //是否有任意鼠标或键盘按下
        if (Input.anyKeyDown)
        {
            print("有一个键按下");
            //这一帧的键盘输入
            print(Input.inputString);//打印按下的键
        }

        //手柄输入相关
        //得到连接的手柄的所有按键名字
        string[] strs = Input.GetJoystickNames();

        //某一个手柄键按下
        if( Input.GetButtonDown("手柄按键名"))
        {

        }

        //某一个手柄键抬起
        if (Input.GetButtonUp("手柄按键名"))
        {

        }

        //某一个手柄键被长按
        if (Input.GetButton("手柄按键名"))
        {

        }

        //移动设备触摸相关
        if(Input.touchCount >0)
        {
            Touch t1 = Input.touches[0];
            //获取位置
            print(t1.position);
            //相对于上次位置的变化
            print(t1.deltaPosition);
        }

        //是否启用多点触控
        Input.multiTouchEnabled = false;

        //陀螺仪
        Input.gyro.enabled = true;

        //重力加速度向量
        print(Input.gyro.gravity);

        //旋转速度
        print(Input.gyro.rotationRate);

        //总结
        //input类 提供大部分输入相关的内容
        //鼠标，键盘，触屏，手柄，重力感应
        //鼠标 键盘是必须要掌握的知识
        //今天必须记住 鼠标键盘输入相关的API GetAxis

    }
}
