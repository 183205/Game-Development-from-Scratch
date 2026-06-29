using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Lesson21 : MonoBehaviour
{
    private AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        //一 获取设备麦克风信息

        string[] strs = Microphone.devices;

        for (int i = 0; i < strs.Length; i++) 
        {
            print(strs[i]);
        }

        //二 开始录制
        //参数一 设备名字 传空 默认设备
        //参数二 超过录制长度后 是否重头录制
        //参数三 录制时长 单位是秒
        //参数四 采样率 一般填写44100

        //Microphone.Start(null,false,100,44100);

        //三 结束录制

        //Microphone.end(null);

        //四 获取音频数据用于存储或者传输
        //规则 用于存储数组数据的长度 是用 声道数 * 剪辑长度
        float[] f = new float[clip.channels * clip.samples];
        clip.GetData(f, 0);
        print(f.Length);
    }

    // Update is called once per frame
    void Update()
    {
        //开始录制
        if(Input.GetKeyDown(KeyCode.Space))
        {
            clip = Microphone.Start(null, false, 10, 44100);
        }


        //结束录制
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Microphone.End(null);
            AudioSource s = this.GetComponent<AudioSource>();
            //第一次去获取 没有才添加
            if (s == null)
            {
                s = this.gameObject.AddComponent<AudioSource>();
            }
            s.clip = clip;
            s.Play();
        }
    }
}
