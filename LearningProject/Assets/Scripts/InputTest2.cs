using UnityEngine;

public class InputTest2 : MonoBehaviour {
    
    public float speed;

    private void Update() {

        float inputX = Input.GetAxis("Horizontal")* speed * Time.deltaTime;
        float inputY = Input.GetAxis("Vertical")* speed * Time.deltaTime;

        transform.Translate(inputX, inputY, 0);
    
    }

}