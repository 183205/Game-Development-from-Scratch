using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lesson9 : MonoBehaviour
{
    public Transform v1;
    public Transform son;
    // Start is called before the first frame update
    void Start()
    {
        //一.获取和设置父对象
        //获取父对象
        print(this.transform.parent.name);
        //设置父对象 断绝关系
        this.transform.parent = null;
        //设置父对象 建立关系
        this.transform.parent = v1.transform;

        //通过API来进行父子关系的设置
        this.transform.SetParent(null);//断绝关系
        this.transform.SetParent(v1.transform);//建立关系

        //参数一 父对象
        //参数二 是否保存世界坐标的 位置 缩放 角度 信息
        //  true 会保留 世界坐标下的状态 和父对象 进行计算 得到本地坐标系的信息
        //  false 不会保留 会直接把世界坐标系下的 位置角度缩放 直接赋值到 本地坐标系下
        this.transform.SetParent(v1.transform, true);


        //二.批量断绝儿子的关系
        this.transform.DetachChildren();


        //三.获取子对象
        //按名字找儿子 Find方法可以找到失活的对象 只能找到儿子
        //需要知道父亲是谁才能找到
        this.transform.Find("son");

        //遍历儿子
        //如何知道有多少个儿子
        //失活的儿子也会算数量 只找儿子 不找孙子
        print(this.transform.childCount);
        //通过索引号 去找到自己对应的儿子
        //返回的是transfrom 可以得到儿子的信息
        //this.transform.GetChild(0);//里面的参数要小于this.transform.childCount
        for (int i = 0; i < this.transform.childCount; i++)
        {
            print("儿子的名字" + this.transform.GetChild(i));
        }


        //儿子的操作
        //判断自己的爸爸是谁
        //一个对象 判断自己是不是另一个对象的儿子
        if (son.IsChildOf(v1))// 判断参数是不是我的儿子
        {
            print("是我的儿子");
        }

        //得到自己作为儿子的编号
        print(son.GetSiblingIndex());

        //把自己设置成第一个儿子
        son.SetAsFirstSibling();

        //把自己设置成最后一个儿子
        son.SetAsLastSibling();

        //把自己设定成指定的儿子 参数超出范围就会变成最后一个
        son.SetSiblingIndex(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
    //总结
    //设置父对象 相关内容
    //获取子对象

    //儿子的操作

}
