using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [Header("追蹤速度"), Range(0, 50)]
    public float speed = 1.5f;
    [Header("上下邊界")]
    public Vector2 limitv = new Vector2(-5, 5);
    [Header("左右邊界")]
    public Vector2 limitx = new Vector2(-5, 5);

    public float a = 0;
    public float b = 100;
    private void updata()
    {
        a = Mathf.Lerp(a, b, 0.5f);
    }

}
