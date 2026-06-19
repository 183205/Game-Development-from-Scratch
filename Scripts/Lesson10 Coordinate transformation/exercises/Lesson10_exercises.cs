using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10_exercises : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {



    }

    [ContextMenu("左前方创建空物体")]
    void Textfan1()
    {
        //练习题一
        GameObject obj = new GameObject("左前方空物体");
        obj.transform.position = this.transform.TransformPoint(new Vector3(-1, 0, 1));

    }
    [ContextMenu("面前创建三个球体")]
    void Textfan2()
    {
        //练习题二
        GameObject obj1 = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        GameObject obj2 = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        GameObject obj3 = GameObject.CreatePrimitive(PrimitiveType.Capsule);

        obj1.transform.position = this.transform.TransformPoint(new Vector3(0, 0, 1));
        obj2.transform.position = this.transform.TransformPoint(new Vector3(0, 0, 2));
        obj3.transform.position = this.transform.TransformPoint(new Vector3(0, 0, 3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
