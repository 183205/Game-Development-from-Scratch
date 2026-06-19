using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class tools
{
    //把子对象的名字按长度排序
    //思路 先把子对象都放入一个 list容器中 对list排序
    //排序完毕后 遍历list 去设置 每个对象的位置
    public static void sort( this Transform niubi)
    {
        List<Transform> list = new List<Transform>();
        for (int i = 0; i < niubi.childCount; i++)
        {
            list.Add( niubi.GetChild(i) );
        }
        list.Sort((a, b) =>
        {
            if (a.name.Length< b.name.Length)
                return -1;
            else return 1;

        });
        for (int i = 0; i < list.Count; i++) 
        {
            list[i].SetSiblingIndex(i);
        }
    }

    //根据名字查到子对象 直到查到为止 可以找儿子的儿子
    public static Transform Superfind(this Transform father,string childName) 
    {
        //我要找的子对象
        Transform target = null;

        //先从自己的身上找
        target = father.Find(childName);
        if (target != null) {return target;}

        //如果自己身上没找到 那就找儿子身上的
        //从儿子的身上找

        for (int i = 0;i < father.childCount;i++)
        {
            target =  father.GetChild(i).Superfind(childName);
            if(target != null) {return target;}
        }

        return target;
    }
}
