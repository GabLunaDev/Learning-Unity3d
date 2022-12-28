using UnityEngine;

public class NewTest : MonoBehaviour {
    GameObject ball;
    public GameObject[] ballsArray;

    private void Start() {
        InvokeRepeating("RandomBalls", 2f, 1f);
    }

    private void Update() {

        if( Input.GetMouseButtonDown(0) )
            RandomBalls();

        
    }

    void RandomBalls(){
        int randomNumber = Random.Range(0, ballsArray.Length);
        ball = ballsArray[randomNumber];

        GameObject ballSummoned = Instantiate(ball, transform.position, Quaternion.identity);
        Destroy(ballSummoned, 1.5f);
    }

}