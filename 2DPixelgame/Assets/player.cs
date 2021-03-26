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
    private void Attack()
    {

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
