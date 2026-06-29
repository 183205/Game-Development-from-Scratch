using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Light light;
    // Start is called before the first frame update
    void Start()
    {
        //一 面板参数
   //     Type 光源类型
   //  Spot 聚光灯
   //    Range 发光范围距离
   //    Spot Angle 光锥角度

   //  Directional  方向光

   //  Point点光源

   //  Area 面光源

   //Color 颜色

   //Mode 光源模式
   //  Realyime 实时光源 每帧实时计算 效果好 性能消耗大

   //  Baked 烘焙光源 事先计算好 无法动态变化

   //  Mixed 混合光源 预先计算+实时运算

   //Intensit 光源亮度

   //Indirect Multiplier 改变间接光的强度 低于一 每次反弹光变暗 高于一则相反

   //Shadow Type
   //  NoShadows 关闭阴影

   //  HardShadows 生硬阴影

   //  SoftShadows柔和阴影

   //RealtimeShadows
   //  Strength 阴影暗度 0 - 1 之间 ，越大越黑

   //  Resolution 阴影贴图渲染分辨率 越高越逼真 消耗越高

   //  Bias 阴影推离光源的距离

   //  Normal Bias 阴影投射面沿法线

   //  Near Panel 渲染阴影的近裁剪面

   //Cookie 投影遮罩

   //Cookie Size 遮罩大小

   //Draw Halo 球形光环的开关

   //Flare 耀斑

   //Render Mode 渲染优先级
   //  Auto 运行时确认

   //  Important 以像素质量为单位进行渲染 效果逼真 消耗大

   //  Not Important 以快速模式进行渲染

   //Culling Mask 剔除遮罩层 决定哪些层级的对象受到该光源的影响


        //二 代码控制
        light.intensity = 0.5f;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
