using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 1.0f;
    [SerializeField] float[] forwardBoostSpeedsArray = { 900.0f, 1200.0f, 1500.0f };
    public float forwardSpeed = 700.0f;
    private float timeCollisioned;
    private int timesCollisioned = 0;
    private bool collisioned;
    void Update()
    {
        float rotationAmount = Input.GetAxis("Horizontal") * rotationSpeed;
        float forwardAxisAmount = Input.GetAxis("Vertical");
        float forwardAmount = forwardAxisAmount * forwardSpeed;

        if (forwardAmount > 0)
        {
            transform.Translate(0, forwardAmount / 100 * Time.deltaTime, 0);
            transform.Rotate(0, 0, -rotationAmount / (3 * forwardSpeed * Time.deltaTime) * forwardAxisAmount);
        }
        else if (forwardAmount < 0)
        {
            transform.Translate(0, forwardAmount / 300 * Time.deltaTime, 0);
            transform.Rotate(0, 0, -rotationAmount / (4 * forwardSpeed * Time.deltaTime) * forwardAxisAmount);
        }

        if (timeCollisioned >= 2 && collisioned)
        {
            forwardSpeed = 700.0f;
            collisioned = false;
            timesCollisioned = 0;
        }

        timeCollisioned += Time.deltaTime;
    }
    
    // Fun��o que verifica se o objeto com o script colidiu com outro objeto com trigger ativado
    void OnTriggerEnter2D(Collider2D collision)
    {
        timeCollisioned = Time.deltaTime;

        if (collision.gameObject.CompareTag("Boost") && timesCollisioned < 3)
        {
            forwardSpeed = forwardBoostSpeedsArray[timesCollisioned];
            timesCollisioned += 1;
            collisioned = true;
        }
    }
}
    