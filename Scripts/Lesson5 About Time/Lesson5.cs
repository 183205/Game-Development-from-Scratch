using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        //Time是用来参与位移，计时，时间暂停等

        //时间缩放比例
        Time.timeScale = 0;//时间停止
        Time.timeScale = 1;//时间恢复
        Time.timeScale = 2;//时间两倍速


        //帧间隔时间
        //意识是 最近的一帧 用来多少时间单位是秒
        //受Scale影响
        print("帧间隔时间"+ Time.deltaTime);
        //不受Scale影响
        print("不受帧间隔时间"+Time.unscaledDeltaTime);
    }
}
