using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player以外につけるやつ : MonoBehaviour
{
    //以下本文
    [SerializeField] float power = 1;
    float moveTime = 1;

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

}