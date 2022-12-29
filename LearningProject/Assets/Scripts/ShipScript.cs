using UnityEngine;

public class ShipScript : MonoBehaviour
{
    public float speedSides;

    Vector3 positionValues;
    public float speedShip;

    private void Update() {
        float inputX = Input.GetAxis("Horizontal") * speedSides * Time.deltaTime;
        float animationTime = inputX * 18;
        float inputY = speedShip * Time.deltaTime;
        
        positionValues = new Vector3(inputX, 0, inputY);

        Quaternion rotationValue = transform.rotation;

        transform.position += positionValues;

        if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 ){
            if((rotationValue.y > -0.35f) && (rotationValue.y < 0.35)){
                transform.Rotate(0, animationTime, 0); 
            }
            
            if(rotationValue.y > - 0.20f && Input.GetAxisRaw("Horizontal") == -1){
                transform.Rotate(0, -0.8f, 0);
            }

            if(rotationValue.y < 0.20f && Input.GetAxisRaw("Horizontal") == 1){
                transform.Rotate(0, 0.8f, 0);
            }
        }
        else if(rotationValue.y < 0){
            transform.Rotate(0, 0.2f, 0);
        }else if(rotationValue.y > 0){
            transform.Rotate(0, -0.2f, 0);
        }
    }
}
