using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Vector3基础
        //主要是用来表示三维坐标系中的 一个点 或者一个向量
        //申明
        Vector3 v = new Vector3();//声明了一个点
        v.x = 0;
        v.y = 0;
        v.z = 0;
        //直传xy 默认z是0 用于2d
        Vector3 v2 = new Vector3(10,10);
        //一步到位
        Vector3 v3 = new Vector3(10,10,10);

        //Vector3基本计算
        //+ - * /
        Vector3 v4 = new Vector3(10, 10, 10);
        Vector3 v5 = new Vector3(9, 9, 9);
        //加减法
        print(v4 + v5);
        print(v4 - v5);
        //乘法
        print(v4 * 2);
        //除法
        print(v4 / 2);

        //常用
        print(Vector3.zero);//000
        print(Vector3.right);//100
        print(Vector3.left);//-001
        print(Vector3.forward);//001
        print(Vector3.back);//00-1
        print(Vector3.up);//010
        print(Vector3.down);//0-10

        //常用方法
        //计算两个点之间的距离
        print(Vector3.Distance(v4, v5));


        //位置
        //相对于世界坐标的位置信息
        print(this.transform.position);//一定是世界坐标系的相对位置 0，0，0
        //this.gameObject.transform;
        //相对于父对象
        print(this.transform.localPosition);
        //注意：位置x，y，z的改变不能直接赋值 只能整体改变
        //不能单独改x,y,z
        this.transform.position =  new Vector3(10,10,10);
        this.transform.localPosition = Vector3.up * 10;
        //如果只想改一个值
        //1.直接赋值
        this.transform.localPosition = new Vector3(19,this.transform.position.y, this.transform.position.z);
        //2.先取出来，在赋值
        Vector3 vpos = this.transform.position;
        vpos.z = 19;
        this.transform.position = vpos;

        //对象当前的各朝向
        //对象当前的面朝向
        print(this.transform.forward);
        //对象当前的头朝向
        print(this.transform.up);
        //对象当前的右朝向
        print(this.transform.right);



    }

    // Update is called once per frame
    void Update()
    {
        //位移
        //理解坐标系下的位移计算公式
        //路程 = 方向 * 速度 * 时间

        //方式一 自己计算
        //用当前位置 + 我要动多长距离  得出最终所在的位置
        //this.transform.position = this.transform.position + this.transform.forward * 1 * Time.deltaTime;
        
        //应为用的是 this.transform.forward 所以始终会朝向相对于自己的面移动
        //this.transform.position += this.transform.forward * 1 * Time.deltaTime;
        
        //这个是根据世界坐标移动
        //this.transform.position += Vector3.forward * 1 * Time.deltaTime;
        
        //方式二 API
        //参数一：表示位移多少 路程 = 方向 * 速度 * 时间
        //参数二：表示 相对坐标系 默认 该参数相对于自己动

        //相对于世界的面朝向
        this.transform.Translate(Vector3.forward * 1 * Time.deltaTime,Space.World);

        //相对自己的面朝向
        this.transform.Translate(this.transform.forward * 1 * Time.deltaTime, Space.World);




    }

    //总结
    //Vertor3
    //如何申明 提供的 常用静态属性 和一个 计算距离的方法
    //位置
    //相对与时间坐标系 和 相对于父对象 这两个坐标的区别
    //不能够单独修改 xyz 只能一起统一修改
    //位移
    //自己如何计算来进行位移
    //API是那Transla 来进行位移 使用时需要注意 不要叠加位移
}
