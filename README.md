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
     
