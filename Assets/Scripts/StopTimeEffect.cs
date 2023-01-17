using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTimeEffect : MonoBehaviour
{
    [SerializeField] string tag = null;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tag))
        {

            //Getcomponentでインターフェースを取得する
            //ITestA testA = other.GetComponent<ITestA>();
            //testA.速度変化();
            ISlow Slower = other.GetComponent<ISlow>();
            Slower.GetStop();

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(tag))
        {
            ISlow Slower = other.GetComponent<ISlow>();
            Slower.GetNormal();
        }
    }



}
