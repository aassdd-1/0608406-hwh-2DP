using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public GameObject prop;
    public float percent =0.7f;


    public void DropProp()
    {
       float r = Random.Range(0f, 1f);

        print("隨機值;" + r);
    }

}
