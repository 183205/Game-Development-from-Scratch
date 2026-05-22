using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //先找到B
        GameObject B = GameObject.Find("B");
        //获得B上面的脚本
        B1 b1 = B.GetComponent<B1>();
        //失活
        if (b1 != null)
        {
            b1.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
