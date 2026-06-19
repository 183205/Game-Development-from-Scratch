using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8 : MonoBehaviour
{
    public Transform obj;
    // Start is called before the first frame update
    void Start()
    {
        //缩放相关
        //相对世界坐标系的缩放
        print(this.transform.lossyScale);
        //相对于本地坐标系
        print(this.transform.localScale);
        //同样缩放也不可以直接单独改xzy (相对于世界坐标系的缩放大小只能看 不能改)
        this.transform.localScale = new Vector3(1,1,1);
        //unity 没有提供关于缩放的api

        //看向
        //让一个对象的面朝向 可以一直看向某一个点或者某一个对象
        //都是相对于世界坐标系
        //这个是看向一个点
        this.transform.LookAt(Vector3.zero);
        //这个是看向一个对象 就是传入一个对象的transfrom
        this.transform.LookAt(obj);

    }

    // Update is called once per frame
    void Update()
    {
        //看向
        //让一个对象的面朝向 可以一直看向某一个点或者某一个对象
        //都是相对于世界坐标系
        //这个是看向一个点
        this.transform.LookAt(Vector3.zero);
        //这个是看向一个对象 就是传入一个对象的transfrom
        this.transform.LookAt(obj);
    }

    //总结
    //相对于 世界坐标 的缩放 只能看 不能改
    //只能修改本地对于父对象的缩放
    //没有提供缩放的API
    //看向 Lookat 看向一个点或者看向一个对象
    //要写在update才会不停变化
}
