using UnityEngine;

public class GetComponentTest : MonoBehaviour {

    Rigidbody rb;
    GameObject cube;

    private void Start() {

        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;

        Destroy(cube, 2f);
    }

    private void Update() {
        
    }
}