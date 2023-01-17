using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _movePower = 5f;
    [SerializeField] public float t = 1f;
    [SerializeField] public int p_hp = 500;
    [SerializeField] GameObject HalfBareer = null;
    [SerializeField] GameObject StopBareer = null;
    [SerializeField] GameObject[] _bareerType = null;
    Rigidbody _rb = default;
    /// <summary>入力された方向</summary>
    Vector3 _dir;

    void Start()
    {
        HalfBareer.SetActive(false);
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // 入力を受け付ける
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        // 入力された方向を「カメラを基準とした XZ 平面上のベクトル」に変換する
        _dir = new Vector3(h, 0, v);
        _dir = Camera.main.transform.TransformDirection(_dir);
        _dir.y = 0;

        // 動いている方向を向く
        //Vector3 dir = _rb.velocity;
        //dir.y = 0;

        //if (dir != Vector3.zero)
        //{
        //    this.transform.forward = dir;
        //}
        if (Input.GetMouseButtonDown(0))
        {
            //GameObject AnotherDimension = Instantiate(HalfBareer, this.transform.position, this.transform.rotation);
            HalfBareer.SetActive(true);
        }
        
        if(Input.GetButtonDown("Fire3"))
        {
            _movePower = 2 * _movePower;
        }
    }

    void FixedUpdate()
    {
        _rb.AddForce(_dir.normalized * _movePower/t);
        
    }
}
