using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour,ISlow
{
    [SerializeField] float power = 1;
    float moveTime = 1;

    Transform playerTransform = null;
    Transform positionMove = null;
    Rigidbody rigidbody = null;
    void Start()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        rigidbody = GetComponent<Rigidbody>();
        //Debug.Log(playerTransform.position);
        
    }

    public void GetSlow()
    {

        moveTime = 0.5f;

    }
    public void GetNormal()
    {
        moveTime = 1.0f;
    }

    public void GetStop()
    {
        moveTime = 0f;
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 dir = -(transform.position - playerTransform.position).normalized;//normalized→単位ベクトル
        dir.y = 0;

        dir *= power;

        //rigidbody.AddForce(dir * power, ForceMode.Acceleration);

        rigidbody.velocity = dir * moveTime;

        Debug.Log("moveTime:"+moveTime+" 速度:"+ rigidbody.velocity);
        

    }

    
    
}
