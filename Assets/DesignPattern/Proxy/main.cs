using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///  客户端代码 
/// </summary>
public class main : MonoBehaviour {

    /// <summary>
    ///实例化 代理类
    /// </summary>
   
     ///实例化  代理
     //  用代理类实现相关的功能
   
	// Use this for initialization
	void Start () {
        RealSubject thenew = new RealSubject();
  
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   /// <summary>
   ///工厂模式  客户端实现代码
   /// </summary>
   void Factory_main()
    {
        /// 实现接口
        IFactory OperaFatory = new AddFactory();  // 客户端 根据需要  选择相应的工厂
        Operation opera = OperaFatory.CreateOperation();
        opera.NumberA = 1;
        opera.NumberB = 2;
        double result = opera.GetResult();  // 计算出结果

    }


    /// <summary>
    /// 建造者  模式  的用户界面
    /// </summary>
   void Builder_main()
    {
        Sprite s = new Sprite();
        Graphics NewGra =new Graphics ();
        Sprite NewSpri = new Sprite();
        //首先根据用户的需要定义一个 需要建造的小人
        PersonThinBuilder ThinPerson = new PersonThinBuilder(NewGra ,NewSpri) ;
        //通知  建造模式的 指挥者 建造房子
        PersonDirector Perdic = new PersonDirector(ThinPerson);
        //指挥类  进行建造
        Perdic.CreatPerson();
       
        
    }
   

    /// <summary>
    /// 建造者模式的基本类
    /// </summary>
   void  Build_Base_main()
    {
        Director director = new Director();   //声明一个指挥者
        Builder B1 = new ConcreteBuilder();  //声明 一个建造者

        director.Construct(B1);  //根据用户的需要建造商品
        Product p1 = B1.GetResult();  // 得到结果  进行商品的建造
        p1.Show(); // 进行  显示商品
       
    }


    /// <summary>
    /// 观察者模式的 客户端代码
    /// </summary>
    void Observer_main()
    { 
        ///声明一个新的主题对象
        ConcreteSubject s = new ConcreteSubject();
        
        // 为主题对象  增加观察者
        s.Attach(new ConcreteObserver(s, "X"));
        s.Attach(new ConcreteObserver(s, "Y"));
        s.Attach(new ConcreteObserver(s, "Z"));

        ///更新主题的 状态
        s.SubjectState = "ABC";
        s.Notify();

        Debug.Log("通知成功");
      } 
}
