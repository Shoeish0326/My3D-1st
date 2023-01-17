using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayableBase : MonoBehaviour
{
    [SerializeField] public int p_hp, p_atk;
    [SerializeField] public float T = 1f, p_movepower = 5f, p_jumppower = 8f;
    Rigidbody _rb = default;
    Vector3 p_dir;
    // Start is called before the first frame update

    
    public virtual void Jumping()
    {
        //if(Input.GetAxis(space))
        //{

        //}
    }
    public virtual void KeyControll()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        p_dir = new Vector3(h, 0, v);
        p_dir = Camera.main.transform.TransformDirection(p_dir);
        p_dir.y = 0;
    }
}
