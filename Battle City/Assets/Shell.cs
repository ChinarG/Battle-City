using UnityEngine;
using System.Collections;

public class Shell : MonoBehaviour
{
    public GameObject ShellExplosion;
    void Start()
    {

    }

    void Update()
    {

    }



    /// <summary>
    /// 触发检测
    /// </summary>
    /// <param name="col"></param>
    public void OnTriggerEnter(Collider col)
    {
        GameObject go=Instantiate(ShellExplosion, transform.position, transform.rotation)as GameObject;//实例化
        Destroy(go.gameObject,1.5f);//删除特效
        Destroy(gameObject);//删除
        if (col.tag=="Tank")
        {
            col.SendMessage("TakeDamage");
        }
    }
}

