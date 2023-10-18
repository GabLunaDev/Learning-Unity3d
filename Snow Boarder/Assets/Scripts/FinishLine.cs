using Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] GameObject cameraToHold;
    [SerializeField] ParticleSystem finishEffect;
    CinemachineVirtualCamera vc;

    void Start(){
        vc = cameraToHold.GetComponent<CinemachineVirtualCamera>();
        finishEffect.Pause();
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            vc.Follow = gameObject.transform;
            finishEffect.Play();
            Invoke(nameof(RestartLevel), 2f);
        }
    }

    void RestartLevel(){
        SceneManager.LoadScene("Level-1");
    }
}
