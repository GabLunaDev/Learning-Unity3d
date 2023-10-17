using Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] GameObject cameraToHold;
    CinemachineVirtualCamera vc;

    void Start(){
        vc = cameraToHold.GetComponent<CinemachineVirtualCamera>();
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            vc.Follow = gameObject.transform;
            Invoke(nameof(RestartLevel), 2f);
        }
    }

    void RestartLevel(){
        SceneManager.LoadScene("Level-1");
    }
}
