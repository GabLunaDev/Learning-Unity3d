using UnityEngine;

public class NewTest : MonoBehaviour {
    GameObject ball;
    bool randomBallsActive;
    public GameObject[] ballsArray;

    private void Start() {
        randomBallsActive = true;
        InvokeRepeating("RandomBalls", 2f, 1f);
    }

    private void Update() {
        if( Input.GetMouseButtonDown(0) ){
            RandomBalls();
        }

        if(Input.GetButtonDown("Jump") && randomBallsActive){
            CancelInvoke("RandomBalls");
            randomBallsActive = false;
        }
        else if(Input.GetButtonDown("Jump") && !randomBallsActive){
            InvokeRepeating("RandomBalls", 0f, 1f);
            randomBallsActive = true;
        }

    }

    void RandomBalls(){
        int randomNumber = Random.Range(0, ballsArray.Length);
        ball = ballsArray[randomNumber];

        GameObject ballSummoned = Instantiate(ball, transform.position, Quaternion.identity);
        Destroy(ballSummoned, 1.5f);
    }

}