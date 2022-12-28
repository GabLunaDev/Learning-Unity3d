using UnityEngine;

public class InputTest : MonoBehaviour {
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space)){
            print("Space Pressed!");
        }
        if(Input.GetKey(KeyCode.Space)){
            print("Space Held Down");
        }
    }
}