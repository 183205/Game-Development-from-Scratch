using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesoon10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //世界坐标系 转本地坐标系 可以帮助我们大概判断一个相对位置

        //一 世界坐标系转本地坐标系
        //世界坐标系的点 转换 为相对本地坐标系的点
        //会受到缩放影响
        print(Vector3.forward);
        print(this.transform.InverseTransformPoint(Vector3.forward));


        //世界坐标系的方向 转换 为相对本地坐标系的方向
        //不受缩放影响
        print(Vector3.forward);
        print("转换后的方向"+ transform.InverseTransformDirection(Vector3.forward));

        //会受到缩放影响
        print("转换后的方向(受到缩放的影响)"+ transform.InverseTransformVector(Vector3.forward));

        //二 本地坐标系转换世界坐标系
        //本地坐标系的点 转换 为相对世界坐标系的点 受到缩放影响
        print("本地 转 世界 点" + this.transform.TransformPoint(Vector3.forward));

        //本地坐标系的方向 转换 相对世界坐标系的方向
        //不受缩放影响
        print("本地方向 转 世界 方向" + this.transform.TransformDirection(Vector3.forward));

        //受到缩放影响
        print("本地方向 转 世界 方向" + this.transform.TransformVector(Vector3.forward));
    }

    //总结
    //主要是的本地坐标系 转 世界坐标系

    // Update is called once per frame
    void Update()
    {
        
    }
}
