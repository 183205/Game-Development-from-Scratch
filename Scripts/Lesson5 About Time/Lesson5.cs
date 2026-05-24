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
        //意思是 最近的一帧 用来多少时间单位是秒
        //主要是用来计算位移的
        //路程=时间*速度
        //根据需求 选择参与计算的间隔时间
        //如果希望 游戏暂停时就不动 用deltatime
        //如果希望 游戏不受暂停影响 用unscaledDeltaTime
        //受Scale影响
        print("帧间隔时间"+ Time.deltaTime);
        //不受Scale影响
        print("不受帧间隔时间"+Time.unscaledDeltaTime);

        //游戏开始到现在的时间
        //主要用来计时 单机游戏会用到
        print(Time.time);
        print(Time.unscaledTime);

        //物理帧更新时间
        print(Time.fixedDeltaTime);
        print(Time.fixedUnscaledDeltaTime);

        //帧数
        //从现在开始跑了多少帧
        print(Time.frameCount);

        //总结
        //最常用的
        //帧间隔时间
        //时间缩放比例 
        //帧数 (帧同步)
    }
}
