using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_exercises : MonoBehaviour
{
    public int Hp = 3;
    //挡子弹碰到我时 就减血 血量为0了 就移除
    private void OnTriggerEnter(Collider other)
    {
        //由于场上只有一个触发器 所有可以不用判断时什么类型的触发了触发器
        Hp -= 1;
        if ( Hp <= 0 )
        {
            Destroy( this.gameObject );
        }
    }
}
