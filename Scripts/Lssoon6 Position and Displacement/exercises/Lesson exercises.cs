using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessonexercises : MonoBehaviour
{
     public int n =1;
     public object tank;
    // Start is called before the first frame update
    void Start()
    {
        //练习题一
        //在空对象上挂载一个脚本 能用来生成一个n层的金字塔
        //决定层数
        //for(int i = 0; i <= n;i++)
        //{
        //    //每层生成时的起始坐标
        //    Vector3 vlo = new Vector3(-0.5f*i, -1 * i, 0.5f * i);
        //    //决定每层数量
        //    for(int j = 0;j< i*i;j++ )
        //    {
        //        //生成立方体
        //        GameObject obj =  GameObject.CreatePrimitive(PrimitiveType.Cube);
        //        //设置位置
        //        obj.transform.position = vlo + new Vector3(j%i,0, j/i*-1) ;
        //    }
        //}

        //练习题二
        //第二种和第四种

        //练习题三


        
    }

    // Update is called once per frame
    void Update()
    {
        //练习题三
        this.transform.Translate(Vector3.forward * 1 * Time.deltaTime, Space.Self);
        this.transform.Translate(this.transform.forward * 1 * Time.deltaTime, Space.World);
    }
}
