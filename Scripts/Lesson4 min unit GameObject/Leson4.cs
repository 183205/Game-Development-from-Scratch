using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Leson4 : MonoBehaviour
{
    //准备克隆的对象 1.直接是场景上的对象 2.可以是一个预设体
    public GameObject obj1;
    public GameObject obj8;
    // Start is called before the first frame update
    void Start()
    {
        //名字
        print(this.gameObject.name);
        this.gameObject.name = "666我的宝贝";
        print(this.gameObject.name);
        //是否激活
        print(this.gameObject.activeSelf);
        //是否是静态
        print(this.gameObject.isStatic);
        //层级
        print(this.gameObject.layer);
        //标签
        print(this.gameObject.tag);
        //transform
        //this.transform 昨天的 通过mono去等到依附对象的位置信息
        //得到的都是一样的信息 省略的常用
        print(this.gameObject.transform);


        //静态方法
        //创建自带几何体
        //只要得到一个对象就可以得到对象的所有脚本
        GameObject Obj = GameObject.CreatePrimitive(PrimitiveType.Cube);//立方体
        Obj.name = "666";
        //查找对象相关的知识
        //1查找单个对象 找不到失活的对象
        //场景中有多个满足条件的对象 那么就不确定找到的是谁
        //通过对象名字查找
        //这个查找到效率比较低
        GameObject a =GameObject.Find("Lesson3");
        print(a);
        //通过tag找到对象 标签
        //GameObject.FindWithTag("Lesson3");
        //两种都一样都可以使用
        //GameObject.FindGameObjectWithTag("Lesson3");
        //得到某一单个对象 两种方式
        //1.public 从外面直接托上去
        //2.通过api查找
        //2查找多个对象
        //多个查找只能用tag 只能找到激活的
        //GameObject[] s = GameObject.FindGameObjectsWithTag("player");
        //print(s);
        //输出数组

        //克隆对象 他的作用 是根据一个GameObject对象 创建出一个和他一模一样的对象
        GameObject.Instantiate(obj1);

        //删除对象的方法
        GameObject.Destroy(obj8);

        GameObject.Destroy(obj1,10);//第二个参数是延迟删除 单位是秒
        //不仅可以删除对象 还可以删除脚本
        //一般情况下不会马上移除 他会在下一帧把对象移除 
        GameObject.DestroyImmediate(obj1);
        //立即移除一个对象 但是建议用上面的 这个对造成卡顿

        //如果继承的是mono可以省略GameObject

        //过场景不移除
        //默认情况下切换场景 场景对象会自动全部删除
        //如果你希望对象不被移除 可以使用这个代码
        //一般是传 自己依附的GameObject
        GameObject.DontDestroyOnLoad(this.gameObject);

        //GameObject中的成员方法
        //创建空物体
        GameObject obj4 = new GameObject();
        GameObject obj5 = new GameObject("666我的宝贝");
        GameObject obj6 = new GameObject("牛逼666我的宝贝",typeof(Lesson1),typeof(Lesson2));

        //为对象添加脚本
        //继承mono的脚本是 不能new的 如果想要动态的添加继承mono的脚本 在一个对象上
        //可以直接使用GameObject
        //用泛型更方便
        Lesson2 les2 = obj6.AddComponent<Lesson2>();

        //得到脚本和继承mono的类得到脚本的方法一模一样
        this.GameObject();

        //标签比较
        //两种都可以
        gameObject.CompareTag("Player");
        if (this.gameObject.CompareTag("Player"))//返回的是bool值
        {
            print("是Player");
        }
        if (this.gameObject.tag == "Player")
        {
            print("是Player");
        }
        //进行激活和失活

        obj4.SetActive(true);

        //总结
        //GameObject的常用内容

        //基本成员变量
        //名字 失活激化状态 标签 层级 等等

        //静态方法相关
        //创建自带几何体
        //查找场景中的对象
        //实例化对象
        //删除对象
        //过场景不移除对象

        //成员方法
        //为对象 活动添加指定脚本
        //设置失活激活状态
        //和mono 中相同的 得到脚本相关的方法

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
