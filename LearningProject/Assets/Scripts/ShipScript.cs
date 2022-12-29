using UnityEngine;

public class ShipScript : MonoBehaviour
{
    public float speedSides;
    public float speedShip;

    private void Update() {
        float inputX = Input.GetAxis("Horizontal") * speedSides * Time.deltaTime;
        float animationTime = inputX * 18;
        float inputY = - (speedShip * Time.deltaTime);
        
        Quaternion rotationValue = transform.rotation;

        if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 ){
            if((rotationValue.y > -0.35f) && (rotationValue.y < 0.35)){
                transform.Rotate(0, animationTime, 0); 
            }
        }
        else if(rotationValue.y < 0){
            transform.Rotate(0, 0.2f, 0);
        }else if(rotationValue.y > 0){
            transform.Rotate(0, -0.2f, 0);
        }
    }

}
