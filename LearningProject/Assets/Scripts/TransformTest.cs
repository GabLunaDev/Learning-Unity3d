using UnityEngine;

public class TransformTest : MonoBehaviour {
    
    Vector3 pos;
    public int speed;

    private void Start() {


    }

    private void Update() {
        
        pos = new Vector3(0f,(0.1f * speed), 0f);

        transform.position += pos;
    }
}