using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");//水平值 （左右移动）
        float v = Input.GetAxis("Vertical");//水平值 （上下移动）
        //Debug.Log(h);//日志输出水平值
        Debug.Log(v);
        //Time.deltaTime时间间隔
        transform.Translate(new Vector3 (h,v,0) * Time.deltaTime * speed);//镜头移动随着方向键移动（h左右,v上下）
    }
}
