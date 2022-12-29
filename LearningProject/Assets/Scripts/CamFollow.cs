using UnityEngine;

public class CamFollow : MonoBehaviour
{

    public Transform target;
    public float smoothSpeed = 0.125f;

    public Vector3 offset = new Vector3();

    void Update()
    {
        transform.position = target.position - offset;
    }

}
