using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    //項目 類型
    //    等級
  
    public int lv = 1;
    public float speed = 10.5f;
    public bool isDead = false;
    public string cName = "貓咪";
    public FixedJoystick joystick;
    public Transform tra;
    public Animator ani;
    public float rabgeAttack = 2.5f;
    //事件:繪製圖示
    private void OnDrawGizmos()
    {
        //指定圖示顏色(紅,綠,藍,透明)
        Gizmos.color = new Color(1, 0, 0, 0.4f);
        //繪製圖示 球體(中心點,半徑)
        Gizmos.DrawWireSphere(transform.position, rabgeAttack);
    }

    private void Move()
    {
        print("移動");
        float h = joystick.Horizontal;
        print("水平" + h);
        float v = joystick.Vertical;
        print("垂直" + v);

        tra.Translate(h * speed * Time.deltaTime, v * speed * Time.deltaTime, 0);
        ani.SetFloat("水平", h);
        ani.SetFloat("垂直", v);

    }
    public void Attack()
    {
       print("攻擊");

        Physics2D.CircleCast(transform.position, rabgeAttack, -transform.up);


    }
    private void Hit()
    {

    }
    private void Dead()
    {

    }
    private void Start()
    {
        Move();
    }
    private void Update()
    {
        Move();
    }
}
