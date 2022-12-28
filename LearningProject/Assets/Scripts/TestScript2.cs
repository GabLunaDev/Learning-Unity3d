using UnityEngine;

public class TestScript2 : MonoBehaviour {
    
    GameObject cube;
    
    private void Start() {
        cube = GameObject.Find("Cube");

        cube.GetComponent<Rigidbody>().useGravity = false;
    }

    private void Update() {
        
    }
}