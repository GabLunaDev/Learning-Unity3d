using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    Collider2D headCollider;

    void Start()
    {
        headCollider = GetComponent<CircleCollider2D>();
        PauseEffect();
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Floor") && headCollider.IsTouching(other)){
            SurfaceEffector2D surfaceEffector = other.GetComponent<SurfaceEffector2D>();
            surfaceEffector.speed = 1.0f;
            crashEffect.Play();
            Invoke(nameof(PauseEffect), 2f);
            Invoke(nameof(RestartLevel), 2f);
        }
    }

    void RestartLevel(){
        SceneManager.LoadScene("Level-1");
    }

    void PauseEffect(){
        crashEffect.Pause();
    }
}
