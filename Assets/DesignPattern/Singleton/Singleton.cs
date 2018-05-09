using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 单利模式
/// </summary>
 class Singleton
{
    /// <summary>
    ///单利模式
    /// </summary>
    private static Singleton instance;

      /// <summary>
   ///私有化 构造函数 防止外界进行NEW    的操作 /// </summary>
   private     Singleton ()
        {

        }
 
    /// <summary>
    ///  
    /// </summary>
    /// <returns></returns>
    public  static Singleton  GetInstance()
    {
        if (instance == null )
        {
            instance = new Singleton();
        }
        
        return instance;
    }
    
} 