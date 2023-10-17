using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1.0f; 
    Rigidbody2D rdb2d;
    void Start()
    {
        rdb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)){
            rdb2d.AddTorque(torqueAmount);
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            rdb2d.AddTorque(-torqueAmount);
        }
    }
}
