using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //角度相关 
        //相对世界的角度
        print(this.transform.eulerAngles);

        //相对父对象的脚步
        print(this.transform.localEulerAngles);

        //和位置是一样的 只能一起改不能单个改xyz的值
        //如果我们希望改变的角度 是面板上显示的内容 那么一定是改变相对于父对象的角度
        //相对于世界坐标改值
        this.transform.eulerAngles = new Vector3(10, 10, 10);
        //相对于父对象改值
        this.transform.localEulerAngles = new Vector3(10, 10, 10);

        //旋转相关

        //API计算
        //自转
        this.transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime);

    }

    // Update is called once per frame
    void Update()
    {
        //旋转相关

        //API计算
        //自转
        //第一个参数 相当于 是旋转的角度 每一帧
        //第二个参数 默认不填 就是相对于自己坐标系 进行的旋转
        //this.transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime);
        //相对于世界坐标系旋转
        //this.transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime,Space.World);

        //相对于某个轴 转多少
        //参数一：相对于那个轴进行转到
        //参数二；是转动的角度是多少
        //参数三：默认不填 就是相对于自己的坐标系 进行旋转
        this.transform.Rotate(Vector3.up,10 * Time.deltaTime,Space.World);

        //相对于某一个点来转
        //参数一：相当于哪一个点 转圈
        //参数二：相对于参数一的哪一个轴转
        //参数三：转圈的速度 转的读书
        this.transform.RotateAround(Vector3.zero, Vector3.up, 10 * Time.deltaTime);
        

    }

    //总结
    //角度相关和位置相关差不多
    //如何得到角度
    //通过Transform 可以得到相对于世界坐标系和相对于父对象的
    //如何自转和绕着别人转
    //Rotate
    //RotateAround
}
