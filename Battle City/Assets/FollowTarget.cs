using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour
{
    public Transform Player1;
    public Transform Player2;

    private Vector3 _offet;


    void Start()
    {
        _offet = transform.position - (Player1.position + Player2.position) / 2;
    }

    void Update()
    {
        transform.position = _offet + (Player1.position + Player2.position) / 2;

        float distance = Vector3.Distance(Player1.position, Player2.position);//1和2的距离

        float size = distance * 0.58f;

        GetComponent<Camera>().orthographicSize = size;
    }
}

