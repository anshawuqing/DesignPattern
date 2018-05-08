using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
/// 发起人  负责创建备忘录 Memento 用以记录   当前时刻它的内部状态，并可使用备忘录 
/// 回复内部状态 
/// </summary>
 class Originator
{
 ///<summary>
///  需要保存的属性
/// </summary>
    private string state;

    public  string State
    {
        get { return state; }
        set { state = value; }
    }

    /// <summary>
    ///创造 备忘录
    /// </summary>
    /// <returns></returns>
   public  Memento  CreateMemento()
    {
        return (new Memento(state));
    }
  
    /// <summary>
    ///  恢复 备忘录  将 Memento 导入并将相关数据恢复
    /// </summary>
    /// <param name="memento"></param>
    public void  SetMemento( Memento  memento)
    {
        state = memento.State;
    }

    /// <summary>
    /// 显示数据
    /// </summary>
    public  void Show()
    {
        Debug.Log("备忘录的状态" + state);
    }
}
