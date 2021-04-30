using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hp : MonoBehaviour
{
    public Image Bar;
    /// <summary>
    /// 血條跟最大值
    /// </summary>
    /// <param name="hp">當天血量</param>
    /// <param name="hpmax">血量最大值</param>
    public void Updatehpbar(float hp,float hpmax)
    {
        Bar.fillAmount = hp / hpmax;
    }

    //internal static void Updatehpbar(Hp hp, float hpmax)
    //{
        //throw new NotImplementedException();
    //}

    //public static implicit operator Hp(float v)
    //{
        //throw new NotImplementedException();
    //}
}
