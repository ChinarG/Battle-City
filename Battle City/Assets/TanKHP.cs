using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TanKHP : MonoBehaviour
{
    public GameObject TankExplosion;
    public int hp = 100;
    public AudioClip TankExplosionAudioClip;//爆炸音效
    public Slider HpSlider;
    private int _hpTotal;

	void Start ()
	{
	    HpSlider = transform.Find("HpSlider/Slider").GetComponent<Slider>();
	    _hpTotal = hp;
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
        HpSlider.value = (float)hp / _hpTotal;
        if (hp<=0)//如果血量减少过后，播放死亡效果
        {
            //transform.position + Vector3.up 向上移动一米
            AudioSource.PlayClipAtPoint(TankExplosionAudioClip,transform.position);//在某个点播放音效
            Instantiate(TankExplosion, transform.position + Vector3.up, transform.rotation);
            Destroy(gameObject);
        }
    }
}
