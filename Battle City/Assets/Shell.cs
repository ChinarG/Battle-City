using UnityEngine;
using System.Collections;

public class Shell : MonoBehaviour
{
    public GameObject ShellExplosion;

    private AudioSource _audio;

    public AudioClip ShellExplosionAudioClip;//创建一个音效 子弹爆炸

    void Start()
    {

    }

    void Update()
    {
        _audio = GetComponent<AudioSource>();
    }



    /// <summary>
    /// 触发检测
    /// </summary>
    /// <param name="col"></param>
    public void OnTriggerEnter(Collider col)
    {
        AudioSource.PlayClipAtPoint(ShellExplosionAudioClip,transform.position);
        GameObject go=Instantiate(ShellExplosion, transform.position, transform.rotation)as GameObject;//实例化
        Destroy(go.gameObject,1.5f);//删除特效
        Destroy(gameObject);//删除
        if (col.tag=="Tank")
        {
            col.SendMessage("TakeDamage");
        }
    }
}

