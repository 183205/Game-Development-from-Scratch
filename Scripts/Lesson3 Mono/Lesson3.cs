using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{


    void Start()
    {
        //Mono重要成员
        //1.获取依附的GameObject
        print(gameObject);
        //2.获取衣服的GameObject的位置信息
        print(transform.position);//位置
        print(transform.eulerAngles);//角度
        print(transform.lossyScale); //数据大小
        //3.获取脚本是否激活

        this.enabled = false ;

        //Mono重要方法
        //1.得到自己挂载的单个脚本 获取失败返回null
        Lessson3_Test t = this.GetComponent("Lesson3_Test") as Lessson3_Test;
        print(t);
        //根据Type获取
        t = this.GetComponent("Lessson3_Test") as Lessson3_Test;
        print(t);
        //根据泛型获取 不用转换
        t = this.GetComponent<Lessson3_Test>();
        print(t);
        //只要能得到场景中其他对象的脚本 就可以得到对象的所有信息

        //2.得到自己挂载的多个脚本
        Lesson3[] array = this.GetComponents<Lesson3>();
        print(array.Length);
        List<Lesson3> list = new List<Lesson3>();

        //3.得到子对象挂载的脚本（它默认也会找自己身上是否挂载脚本）
        t = this.GetComponentInChildren<Lessson3_Test>();//有参数 默认不传是false 子对象未激活不获取 参数是true 子对象失活也会获取
        print(t);
        //得到多少 子对象挂载了这个脚本
        Lessson3_Test[] l = this.GetComponentsInChildren<Lessson3_Test>();
        print(l.Length);

        //4. 得到父对象挂载的脚本（它默认也会找自己身上是否挂载脚本）
        t = this.GetComponentInParent<Lessson3_Test>(); 
        print(t);
        Lessson3_Test[] w = this.GetComponentsInParent<Lessson3_Test>();
        print(w.Length);

        //5.尝试获取脚本
        Lessson3_Test L3t;
        //提供了一个更安全的 获取单个脚本的方法 得到了会返回true
        if(this.TryGetComponent<Lessson3_Test>(out L3t))
        {
            //逻辑处理
        }
 

    }

    private T[] GetComponentInParents<T>()
    {
        throw new NotImplementedException();
    }

    void Update()
    {
        
    }
}
