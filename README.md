# Game-Development-from-Scratch
该学习了 改成长了


5.18号

   学习Inspector和Console窗口的使用
   
<img width="1000" height="500" alt="image" src="https://github.com/user-attachments/assets/a51240c4-6aee-4bce-ad17-3a0c1828ac3a" />

   1.Inspector窗口
<img width="1000" height="500" alt="image" src="https://github.com/user-attachments/assets/53d0499a-36b3-486a-bf3e-9b9d13422fc8" />

   2.Console窗口


   3.总结
<img width="1000" height="500" alt="image" src="https://github.com/user-attachments/assets/64725def-f428-4f97-9045-4ebf4d375180" />


习题 完成一个45度角显示的金字塔
<img width="1003" height="542" alt="image" src="https://github.com/user-attachments/assets/43008280-0403-45e5-ab7c-ea9d3e4d0c76" />


  学习工具栏和父子关系
  
  工具栏
  
  <img width="1685" height="816" alt="image" src="https://github.com/user-attachments/assets/f65010dc-be39-4f3b-87f0-fedc76c10d30" />
  
  1.Build Settings 打包程序
  2.Project Settings 工程设置
    Preferences 首选项
                 Extemal Tools 开发工具
                 Languages 语言
  3.
  4.Move To View 把对象放在视角中心
  5.
  6.Asset Store 资源商店
  
  父子关系

   树状结构 二叉树
   子对象会随着父对象的变化而变化
   子对象Inspector窗口中Transfor信息是相对父对象的

   习题 用自带建模制作一个坦克 并把制作元素放入一个空建模里变成子对象快捷移动所有坦克建模块

   <img width="1010" height="961" alt="image" src="https://github.com/user-attachments/assets/78b51630-dff3-4dfe-867e-46e89c8a5b64" />


5.19 学习C#反射的概念

     概念以及作用
     
<img width="792" height="405" alt="image" src="https://github.com/user-attachments/assets/cd87c5f3-9cba-41bb-a8d5-43bec98d5737" />

     Unity反射机制
       关联脚本变量
     游戏场景
       场景的本质是配置文件 通过反射机制处理 反馈到游戏场景

     总结
     
<img width="1240" height="712" alt="image" src="https://github.com/user-attachments/assets/d4b7a816-8085-4706-95c0-2166614f0c1e" />

     预设体和资源包的导入导出
       预设体
         把建模拖入Assets就可以创建一个预设体 方便一次性生产复杂建模
         修改预设体可以在Inspector设置重置或者更新
         删除预设体内容需要打开预设体修改 在Inspector open打开
       导入导出 
         右键选中文件  export package 导入可以直接拖进文件或者 inser package
      脚本基本规则
        1.脚本规则
      
   <img width="711" height="280" alt="image" src="https://github.com/user-attachments/assets/40adbaf5-6adf-4d1e-9d3a-a70b24ced6df" />

        2.Mono Behavior基类

   <img width="871" height="318" alt="image" src="https://github.com/user-attachments/assets/04c6d0e1-bdda-4c2d-b890-d175f047de9d" />

        3.不继承Mono 的类

   <img width="917" height="195" alt="image" src="https://github.com/user-attachments/assets/4ada7b78-e528-4a6f-8933-d1ef880ed37b" />

        4.执行的先后顺序
          在脚本右上角可以设置脚本顺序
        5.默认脚本内容
          Editor\Data\Resources\ScriptTempates
5.20 生命周期函数

   游戏的本质是一个死循环
     生命周期函数
       详细见Scripts\Lesson1 Lile Cycly\Lesson1
     总结 
       生命周期函数不打算写入逻辑 不要生成函数 会产生资源浪费
       脚本可以挂载任何对象上面
       对象运行前是失活状态 那么什么函数都不会激活
     
     Inspector窗口可编辑变量
       详细见Scripts\Lesson2 Inspector Window\Lesson2
       
     Mono中的重要内容  
       详细见Scripts\Lesson3 Mono\Lesson3

       练习
       1.脚本A脚本B挂载一个对象上 实现在脚本A中让脚本B失活
       2.脚本A挂载A对象，脚本B挂载B对象，在B对象中让A对象的A脚本失活
       详细见Scripts\Lesson3 Mono\exercises

5.21-5.22GameObject成员变量 方法

   GameObject成员变量
   
   GameObject成员静态方法
   
   GameObject成员方法
   详细见Scripts\Lesson4 min unit GameObject\Lesson4

   练习题
   
   练习1一个空物体上挂了一个脚本,游戏运行时该脚本可以实例化出之前的坦克预设体
  
   练习2一个脚本 A 一个脚本 B, 脚本 A 挂在 A 对象上，脚本 B 挂在 B 对寸象上实现在 A 脚本的 Start 函数中将 B 对象上的 B 脚本失活 (用 GameObject 相关知识做)
   
   练习3一个对象A和一个对象B,在A上挂一个脚本,通过这个脚本司可以让对象改名,失活,延迟删除,立即删除。可以在Inspector窗口进行设置,让B实现不同的效果(提示:GameObject、枚举)
   
   详细见Scripts\Lesson4 min unit GameObject\exercises

   时间相关Time
   详细见Scripts\Lesson5 About Time\Lesson5
5.24 对象的位置和位移

    1.Vector3基础
    2.Vector3基本计算 +-*/
    3.关于对象的位置和位移
    详细见Scripts\Lssoon6 Position and Displacement

    练习题
    1. 一个空对象上挂了一个脚本，这个脚本可以让游戏运行时，在场景中创建出一个 n 层由 Cube 构成的金字塔 (提示：实例化预设体或者实例化自带几何体方法)
    2.this.transform.Translate (Vector3.forward, Space.World);
    this.transform.Translate (Vector3.forward, Space.Self);
    this.transform.Translate (this.transform.forward, Space.Self);
    this.transform.Translate (this.transform.forward, Space.World)
    这四个方法，哪些才能让对象朝自己的面朝向移动？为何？(可以画图说明)
    3. 使用你之前创建的坦克预设体，让其可以朝自己的面朝向向前移动
    详细见Scripts\Lssoon6 Position and Displacement\exercises
5.25 对象的角度和旋转

    1.角度相关 
    2.旋转相关
    详细代码和知识见Scripts\Lesson7 Angle and rotation\Lesson7
    
    练习题
    1.使用你之前创建的坦克预设体,在坦克下面加一个底座(用自带几何体即可)让其可以原地旋转,类似一个展览台
    2.在第一题的基础上,让坦克的炮台可以自动左右来回旋转,炮管可以自动上下抬起
    3.请用3个球体,模拟太阳、地球、月亮之间的旋转移动
    详细代码见Scripts\Lesson7 Angle and rotation\Lesson7\exercises

5.26缩放和看向

   1.缩放
   2.看向
   详细见Scripts\Lesson8 Zoom and look at\Lesson8

   练习题
   使用之前的坦克预设体,让摄像机可以跟随其移动,并且一直看向坦克
   详细见Scripts\Lesson8 Zoom and look at\exercises
5.28父子关系

   一.获取和设置父对象
      父对象的操作
      建立和断绝关系
   二.批量断绝儿子的关系
   三.获取子对象
      find找儿子
      遍历儿子
      判断自己的爸爸是谁
      获得儿子的编号
      设置儿子的编号
   详细见Scripts\Lesson9 father and son\Lesson9

   练习
      把子对象的名字按长度排序
      根据名字查到子对象 直到查到为止 可以找儿子的儿子
   详细见Scripts\Lesson father and son\exercises

6.17坐标转换和input输入

   坐标转换
    一世界坐标系 转本地坐标系
    二本地坐标系 转世界坐标系
    详细见Scripts\Lesson10 Coordinate transformation\Lesson10

   练习
   一个物体A 不管他在什么位置 写一个方法 在他的-1 0 1 的地方生成一个空物体
   一个物体A 不管他在什么位置 写一个方法 在他前面生成三个球体 001 002 003
    详细见Scripts\Lesson10  Coordinate transformation\exercises

   Input输入
    一 返回鼠标在屏幕的位置
    二 检测鼠标的输入
    三 检测键盘输入
    四 检测默认轴的输入
    详细见Scripts\Lesson11 input\Lesson11
    
    练习
    让一个物体根据键盘输入前后左右移动起来
    让一个物体根据鼠标输入旋转方向
    详细见Scripts\Lesson11 input\exercises
     
6.18 Screen 和 Camera

    一 Screen 静态属性
    二 Screen 静态方法
    详细见Scripts\Lesson12 SCreen\Lesson12
    
    练习
    一用鼠标滚轮控制炮管上下移动
    练习题二 
    在上一题的基础上 加入长按鼠标右键移动鼠标
    可以让摄像机围绕着坦克旋转，改变观察坦克的视角
    详细见Scripts\Lesson12 SCreen\exercises

    Camera组件信息
      Clear Flage  如何清除背景
      Skybox         天空盒  主要用于3D
      Solid Color    颜色填充  主要用于2D
      Depth Only     只花该层，背景透明  多个摄像机叠加渲染
      Dont's Clear   不移除，覆盖渲染  基本不用

    Culling Mask  选择性渲染部分层级   可以指定只渲染对应层级的对象

    Projection 
      Perspective 透视模式
        FOV Axis 视角轴  决定了光学仪器的视野范围
        Field of View 视角大小
        Physical Camera 物理摄像机 勾选后可以模拟真实的摄像机
          Focal Length 焦距
          Sensor Type 传感器类型
          Sensor Size 传感器大小
          Lens Shift 透镜移位
          Gate Fit 闸门配合

      Orthographic 正交摄像机(一般用于2D游戏制作)
        Size 摄像范围

    Clipping Planes  裁剪平面距离

    Viewport Rect 视口范围
      主要用于双摄像机游戏
      0-1 相当于宽高百分比

    Depth  渲染顺序上的深度

    Redering Path  渲染路径 默认不修改

    Target Texture  渲染纹理
      可以把摄像机画面渲染在一张图上  主要用于制作小地图
      在Project右键创建 Render Texture 

    Occlusion Culling  是否启动剔除遮挡

    Allow HDR  是否运行高动态范围渲染

    Allow MSAA  是否允许抗锯齿

    Allow Dynamic Resolution  是否允许动态分辨率呈现

    Target Display  用于哪个显示器  主要用来开发有多个屏幕的平台游戏

    练习
    1.用两个摄像机实现分屏效果 用之前制作的可以移动的坦克
      一个摄像机俯视坦克跟随移动  一个摄像机在炮口位置跟随坦克炮口移动
      详细见Scripts\Lesson13 Camera\Lesson13
    2.场景上有两个物体 A B 有两个摄像机 A B
      A摄像机渲染A B摄像机渲染B 玩家能在Game窗口同时看到A和B
      详细见Scripts\Lesson13 Camera\Lesson13_exercises

6.19 Camear Code 相关

   一 重要静态成员
   二 重要成员
   详细见Scripts\Lesson14 Camera Code\Lesson14

   练习
   一 游戏画面中央有一个立方体 请将该立方体的世界坐标位置转换成屏幕坐标位置 并打印出来
   二 在屏幕上点击一下鼠标，则在对应的世界坐标位置 创建一个Cube出来
   详细见Scripts\Lesson14 Camera Code\Lesson14_exercises

6.22 light 相关
   Type 光源类型
     Spot 聚光灯
       Range 发光范围距离
       Spot Angle 光锥角度

     Directional  方向光

     Point点光源

     Area 面光源

   Color 颜色

   Mode 光源模式
     Realyime 实时光源 每帧实时计算 效果好 性能消耗大

     Baked 烘焙光源 事先计算好 无法动态变化

     Mixed 混合光源 预先计算+实时运算

   Intensit 光源亮度

   Indirect Multiplier 改变间接光的强度 低于一 每次反弹光变暗 高于一则相反

   Shadow Type 
     NoShadows 关闭阴影

     HardShadows 生硬阴影

     SoftShadows柔和阴影

   RealtimeShadows
     Strength 阴影暗度 0-1 之间 ，越大越黑

     Resolution 阴影贴图渲染分辨率 越高越逼真 消耗越高

     Bias 阴影推离光源的距离

     Normal Bias 阴影投射面沿法线

     Near Panel 渲染阴影的近裁剪面

   Cookie 投影遮罩

   Cookie Size 遮罩大小

   Draw Halo 球形光环的开关

   Flare 耀斑

   Render Mode 渲染优先级
     Auto 运行时确认

     Important 以像素质量为单位进行渲染 效果逼真 消耗大

     Not Important 以快速模式进行渲染

   Culling Mask 剔除遮罩层 决定哪些层级的对象受到该光源的影响

   练习题
   一 通过代码结合点光源 模拟一个蜡烛的效果
   二 用方向光利用代码转变白天和黑夜的效果
   详细见Scripts\Lesson15 light\exercises
    
