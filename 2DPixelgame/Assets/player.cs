using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    //項目 類型
    //    等級
    [Header("等級")]
    public int lv = 1;
    [Header("移動速度")]
    public float speed = 10.5f;
    [Header("死亡")]
    public bool isDead = false;
    [Header("角色名稱")]
    public string cName = "貓咪";
    [Header("搖桿")]
    public FixedJoystick joystick;
    [Header("")]
    public Transform tra;
    [Header("動畫元件")]
    public Animator ani;
    [Header("偵測範圍")]
    public float rabgeAttack = 2.5f;
    [Header("音效來源")]
    public AudioSource aud;
    [Header("攻擊特效")]
    public AudioClip soundAttack;
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
        aud.PlayOneShot(soundAttack, 0.5f);
        RaycastHit2D hit = Physics2D.CircleCast(transform.position, rabgeAttack, -transform.up,0, 1 << 8 );
        print("碰到的物件:" + hit.collider.name);
        if (hit && hit.collider.tag == "道具") Destroy(hit.collider.gameObject);


    }
    private void hit()
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
