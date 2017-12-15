using UnityEngine;
using System.Collections;

public class TankMove : MonoBehaviour
{
    public float Speed=10;

    public float AngularSpeed=5;

    private Rigidbody _rigidbody;

    public int Number = 1;//增加一个玩家、编号默认1
    void Start()
    {
        _rigidbody = this.GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        //获取垂直位移
        float v = Input.GetAxis("Player" + Number + "Vertical");

        //朝着自身的前方向移动
        _rigidbody.velocity = transform.forward * v*Speed ;

        //获取水平位移
        float h = Input.GetAxis("Player"+Number+"Horizontal");

        //物体转速，沿Y轴 transform.up
        _rigidbody.angularVelocity = transform.up * h * AngularSpeed;

    }


    void Update()
    {

    }
}

