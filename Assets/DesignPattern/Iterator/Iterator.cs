using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 迭代器 抽象类
/// </summary>
  abstract  class Iterator
{

    public abstract object First();
    public abstract object  Next();
    public abstract bool  IsDone ();
    public abstract object CurrentItem ();

}
