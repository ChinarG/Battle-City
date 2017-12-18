using UnityEngine;
using System.Collections;

public class TankAttack : MonoBehaviour
{
    public GameObject ShellPrefab;

    public Transform FirePos;

    public KeyCode FireKey=KeyCode.Space;//发射炮弹键位:默认空格键

    public float ShellSpeed=10;

    public AudioClip ShotAudioClip;//攻击音效
    void Start()
    {
        FirePos = transform.Find("Pos");
    }

    void Update()
    {
        //如果按键被按下
        if (Input.GetKeyDown(FireKey))
        {
            //播放音效
            AudioSource.PlayClipAtPoint(ShotAudioClip,transform.position);

            //发射子弹
            GameObject go= Instantiate(ShellPrefab, FirePos.transform.position, FirePos.transform.rotation)as GameObject;

            //给子弹刚体、添加速度 velocity
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * ShellSpeed;
        }
    }
}

