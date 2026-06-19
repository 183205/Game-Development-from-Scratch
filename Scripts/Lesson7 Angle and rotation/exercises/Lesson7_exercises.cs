using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7_exercises : MonoBehaviour
{
    public Transform v1;
    public Transform v2;
    public Transform v3;
    public Transform head;
    public Transform paokou;
    public int spead = 10;
    public int spead2 = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //练习题一 坦克自转
        //自转
        //this.transform.Rotate(new Vector3(0,10,0) *10*Time.deltaTime);

        //练习题二 让坦克的炮台可以自动左右旋转，炮管可以自动上下抬起
        //head.Rotate(new Vector3(0, 10, 0) * spead * Time.deltaTime);
        //if (!(head.localEulerAngles.y >= 315 && head.localEulerAngles.y<=360)&&
        //    head.localEulerAngles.y>=45 && head.localEulerAngles.y>0)
        //{
        //    spead = -spead;
        //}else if(!(head.localEulerAngles.y <= 45 && head.localEulerAngles.y > 0) &&
        //    (head.localEulerAngles.y <=315 && head.localEulerAngles.y < 0))
        //{
        //    spead = -spead;
        //}
        ////炮管上下移动
        //paokou.Rotate(new Vector3(10, 0, 0) * spead2 * Time.deltaTime);
        //if (!(paokou.localEulerAngles.x >= 350 && paokou.localEulerAngles.x <= 360) &&
        //    paokou.localEulerAngles.x >= 10 && paokou.localEulerAngles.x > 0)
        //{
        //    spead2 = -spead2;
        //}
        //else if (!(paokou.localEulerAngles.x <= 10 && paokou.localEulerAngles.x > 0) &&
        //    (paokou.localEulerAngles.x <= 350 && paokou.localEulerAngles.x < 0))
        //{
        //    spead2 = -spead2;
        //}

        //练习题三 三个球体模拟日月星

        v3.Rotate(new Vector3(0, 10, 0) * 10 * Time.deltaTime);//太阳自转
        v2.Rotate(new Vector3(0, 10, 0) * 10 * Time.deltaTime);//地球自转
        v1.Rotate(new Vector3(0, 10, 0) * 10 * Time.deltaTime);//月球自转
        v2.RotateAround(v3.position, Vector3.up, 10 * Time.deltaTime);//地球公转
        v1.RotateAround(v2.position, Vector3.up, 10 * Time.deltaTime);//月球公转
    }
}
