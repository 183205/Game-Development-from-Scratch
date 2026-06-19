using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson12_excircses : MonoBehaviour
{
    public Transform getlook;
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //练习题一 用鼠标滚轮控制炮管上下移动
        //this.transform.Rotate(Vector3.right * speed * Time.deltaTime * Input.mouseScrollDelta.y * -1);


        //练习题二 
        //在上一题的基础上 加入长按鼠标右键移动鼠标
        //可以让摄像机围绕着坦克旋转，改变观察坦克的视角

        this.transform.LookAt(getlook);

        if (Input.GetMouseButton(1))
        {
            this.transform.RotateAround(getlook.position,//围绕着那个点
                Vector3.up,//围绕着那个轴
                speed *  Time.deltaTime * Input.GetAxis("Mouse X"));//速度
        }

    }
}
