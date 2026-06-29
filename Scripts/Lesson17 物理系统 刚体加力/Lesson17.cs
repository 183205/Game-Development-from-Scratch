using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson17 : MonoBehaviour
{
    Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        // 一 刚体自带添加力的方法
        //给刚体加力的目标就是
        //让其拥有一个速度 朝向某一方向移动

        //1.首先应该获取刚体组件
        body = this.GetComponent<Rigidbody>();

        //2.添加力
        //相对世界坐标
        //body.AddForce(Vector3.forward * 10);
        //相对本地坐标
        //body.AddRelativeForce(Vector3.forward * 10);

        //3.添加扭矩力 让其旋转
        //相对于世界坐标
        //body.AddTorque(Vector3.up * 10);
        //相对于本地坐标
        //body.AddRelativeTorque(Vector3.forward * 10);

        //4.直接改变速度
        //这个速度方向时根据世界坐标移动的
        //body.velocity = Vector3.forward * 10;

        //5.模拟爆炸效果
        //想要多个物体实现效果 需要每个物体都有刚体 和 脚本
        body.AddExplosionForce(100, Vector3.zero, 10);

        //二 力的几种模式
        //力的模式 主要的左右 就是 计算方式不同 最终移速不同
        body.AddForce(Vector3.forward * 10, ForceMode.Impulse);

        //Ft = mv
        //v = Ft/m
        //F 力
        //t 时间
        //m 质量
        //v 速度

        //1.Acceleration 给物体增加一个持续的加速度，忽略其质量
        //v = Ft/m
        //f (0.0.10)
        //t 0.02s
        //m 默认为1

        //2.Force 给物体添加一个持续的力，与物体质量有关

        //3.Impulse 给物体添加一个瞬间的力，与物体的质量有关 忽略时间 默认为1

        //VelocityChaoge 给物体添加一个瞬时速度 忽略质量

        //三 力场脚本

        //Constant Force 可以快捷施加给物体力

        //四 刚体休眠

        //在一定情况下 有可能刚体会失效
        //唤醒刚体
        if(body.IsSleeping())
        {
            body.WakeUp(); 
        }

         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
