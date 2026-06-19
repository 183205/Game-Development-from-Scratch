using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11_execrises : MonoBehaviour
{
    public float movespeed = 10;
    public float Rotatespeed = 10;
    public Transform head;
    public float headRotatespeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //练习题 控制坦克的WASD方向前进 左右转向
        //位移 自转 键盘输入知识点
        //WS 前进和后退
        //公式 方向 * 速度 * 时间 * 当前是否移动
        this.transform.Translate(this.transform.forward * movespeed * Time.deltaTime * Input.GetAxis("Vertical"), Space.World);

        //AD 左右转向
        this.transform.Rotate(this.transform.up * Rotatespeed * Time.deltaTime * Input.GetAxis("Horizontal"), Space.World);

        //炮口方向调整
        //鼠标相关属性
        //Input.GetAxis("Mouse X");左右移动
        head.transform.Rotate(this.transform.up * headRotatespeed * Time.deltaTime * Input.GetAxis("Mouse X"), Space.World);
    }
}
