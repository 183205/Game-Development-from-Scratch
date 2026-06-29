using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson20 : MonoBehaviour
{
    AudioSource audioSource;
    public GameObject obj;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {

     //一 代码控制播放停止

        audioSource = this.GetComponent<AudioSource>();

        //二 如何检测音效播放完毕



        //三 如何动态控制音效播放

        //1.直接在要播放音效的对象上挂载脚本 控制播放

        //2.实例化挂载了音效源脚本的对象
        //这种方法用的少
        Instantiate(obj);

        //3.用一个AudioSource来控制播放不同的音效

        AudioSource aus= this.gameObject.AddComponent<AudioSource>();
        aus.clip = clip;
        aus.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //代码控制音频播放
        //播放
        if (Input.GetKeyDown(KeyCode.P))
        {
            audioSource.Play();
            print("1");
        }
        //停止
        if (Input.GetKeyDown(KeyCode.S))
        {
            audioSource.Stop();
            print("2");
        }
        //暂停
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.Pause();
            print("3");
        }
        //停止暂停
        if (Input.GetKeyDown(KeyCode.X))
        {
            audioSource.UnPause();
            print("4");
        }

        //检测音频是否播放完毕

        if (audioSource.isPlaying)
        {
            print("播放中");
        }
        else
        {
            print("播放完毕");
        }
    }
}
