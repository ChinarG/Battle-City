using UnityEngine;
using System.Collections;

public class TanKHP : MonoBehaviour
{
    public GameObject TankExplosion;
    public int hp = 100;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    /// <summary>
    /// 受到伤害
    /// </summary>
    void TakeDamage()
    {
        if (hp <= 0) return;
        hp -= Random.Range(10, 20);
        if (hp<=0)//如果血量减少过后，播放死亡效果
        {
            //transform.position + Vector3.up 向上移动一米
            Instantiate(TankExplosion, transform.position + Vector3.up, transform.rotation);
            Destroy(gameObject);
        }
    }
}
