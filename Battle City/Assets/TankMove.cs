using UnityEngine;
using System.Collections;

public class TankMove : MonoBehaviour
{
    public float Speed=10;

    public float AngularSpeed=5;

    private Rigidbody _rigidbody;

    public int Number = 1;//增加一个玩家、编号默认1

    public AudioClip IdleAudioClip;

    public AudioClip DrivingAudioClip;

    private AudioSource _audio;

    void Start()
    {
        _rigidbody = this.GetComponent<Rigidbody>();
        _audio = this.GetComponent<AudioSource>();
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


        //判断按键按下
        if (Mathf.Abs(h)>0.1||Mathf.Abs(v)>0.1)
        {
            _audio.clip = DrivingAudioClip;//行驶中

            if (_audio.isPlaying==false)
            {
                _audio.Play();
                _audio.volume = 1;

            }
        }
        else
        {
            _audio.clip = IdleAudioClip;

            if (_audio.isPlaying == false)
            {
                _audio.Play();
                _audio.volume = 1;

            }
               



        }

    }


    void Update()
    {

    }
}

