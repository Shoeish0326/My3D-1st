using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongRangeAttackBase : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        PlayerController pc = GameObject.Find("Player").GetComponent<PlayerController>();

    }
    

}
