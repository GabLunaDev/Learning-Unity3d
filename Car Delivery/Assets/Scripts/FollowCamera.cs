using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    [SerializeField] GameObject car;
    void LateUpdate()
    {
        transform.position = car.transform.position + new Vector3 (0, 0, -12);
    }
}
