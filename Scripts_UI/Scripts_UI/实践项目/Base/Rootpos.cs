using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteAlways] // 可以在编辑模式下也能显示控件
public class Rootpos : MonoBehaviour
{
    //用于存储 子对象 所有GUI控件的容器
    private GUIControl[] allcontrols;
    // Start is called before the first frame update
    void Start()
    {
        allcontrols = this.GetComponentsInChildren<GUIControl>();
    }
    //在这里统一绘制子对象控件内容
    private void OnGUI()
    {
        //通过每一次绘制之前 得到所有子对象控件的 父类脚本
        //这句代码 浪费性能因为每次gui都会来获取所有的 控件对应的脚本
        //编辑状态下 才会一直执行
        if (!Application.isPlaying)
        {
            allcontrols = this.GetComponentsInChildren<GUIControl>();
        }
        //遍历每一个控件 进行绘制
        for (int i = 0; i < allcontrols.Length; i++)
        {
            allcontrols[i].GrawGui();
        }
    }
}
