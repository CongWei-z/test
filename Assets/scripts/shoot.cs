//using System.Collections;
//using System.Collections.Generic;
//using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 5;  //设置初始速度为5


    // Start is called before the first frame update
    void Start()   //初始化的
    {
        Debug.Log("hello"); //控制台打印日志
        //GameObject.Instantiate(bullet,transform.position, transform.rotation);
        //实例化子弹生成在摄像机组件的位置，旋转方向

    }

    // Update is called once per frame
    void Update() //每帧调用
    {
        //Debug.Log("hello");
        if (Input.GetMouseButtonDown(0))  //判断鼠标是否按下，按下就实例化一个buttet
        {
            //参数一：实例化的物体是（bullet） 参数二：实例化预设的坐标  参数三：实例化预设的旋转角度  指定位置
            //此transform指的是当前脚本所在组件的transform，这里指的是摄像机的位置，和旋转角度
           GameObject b = GameObject.Instantiate(bullet,transform.position,transform.rotation);
            Rigidbody rgd = b.GetComponent<Rigidbody>();//得到子弹的刚体组件
            rgd.velocity = transform.forward * speed;//velocity施加速度，照相机的forward（前方向z轴为1），

        }

    }
}
