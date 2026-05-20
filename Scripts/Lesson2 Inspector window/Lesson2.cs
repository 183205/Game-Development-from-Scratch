using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    private int a;
    //1.Inspector显示的属性就是脚本的成员变量 私有和保护不能被看到

    //2.加上强制变量Serialize Field 私有和保护也可以使用

    //3.公共的可以显示和编辑

    //4.公共的不显示可以加HideInInspector

    //5.大部分类型都可以显示编辑 字典和自定义类型不可以显示编辑

    //6.让自定义类型可以被访问 加上System.serializable

    //7.辅助特性
    //1.分组说明Header
    [Header("基础属性")]
    public int age;
    public bool sex;
    //2.[Tooltip]添加说明
    //3.[Space]让两个字段出现一个间隔
    //4.[Range( , )]显示滑条范围

}
