using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson16_exercises : MonoBehaviour
{
    public float movespeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //碰撞到别的东西 子弹就消失
        //一定是移除自己依附的GameObject 而不是脚本自己
        if(collision.gameObject.CompareTag("Ground"))
        {
            Destroy(this.gameObject);
        }
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Destroy(this.gameObject);
        }
    }
}
