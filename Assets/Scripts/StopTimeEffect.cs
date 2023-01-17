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

            //Getcomponent�ŃC���^�[�t�F�[�X���擾����
            //ITestA testA = other.GetComponent<ITestA>();
            //testA.���x�ω�();
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
