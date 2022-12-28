using UnityEngine;

public class InstatiateTest : MonoBehaviour {
    public GameObject[] balls;
    GameObject ballSummoned;
    GameObject ball;

    private void Start() {

    }

    private void Update() {

        if( Input.GetMouseButtonDown(0) ){
            int randomNumber = Random.Range(0,balls.Length);
            ball = balls[randomNumber];

            ballSummoned = Instantiate(ball,transform.position, Quaternion.identity);
            Destroy(ballSummoned, 1.5f);
        }

    }

}