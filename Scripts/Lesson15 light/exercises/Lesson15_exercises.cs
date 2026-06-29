using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson15_exercises : MonoBehaviour
{
    public Light light;
    public float movespeed;
    public float lightspeed;
    public Transform lighttransform;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //练习题一通过代码结合点光源 模拟一个蜡烛的效果
        light.transform.Translate(Vector3.right * movespeed * Time.deltaTime);
        if (light.transform.position.z >= 1)
            movespeed = -movespeed;
        else if(light.transform.position.z <= 0.5f)
            movespeed = -movespeed;
        light.intensity = lightspeed * Time.deltaTime;
        if (light.intensity >= 1)
            lightspeed = -lightspeed;
        else if (light.intensity <= 0.5f)
            lightspeed = -lightspeed;

        //练习题二 用方向光利用代码转变白天和黑夜的效果

        lighttransform.Rotate(Vector3.right, speed * Time.deltaTime);
    }
}
