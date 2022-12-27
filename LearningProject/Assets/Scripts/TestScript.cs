using UnityEngine;

public class TestScript : MonoBehaviour
{
    GameObject[] searchObj;
    void Start()
    {
        
        searchObj = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject obj in searchObj)
        {
            Destroy(obj, 1f);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
