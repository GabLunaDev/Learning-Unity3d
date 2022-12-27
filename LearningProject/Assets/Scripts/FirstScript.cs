using UnityEngine;

public class FirstScript : MonoBehaviour
{

    public bool killObject;

    void Start()
    {
        
    }

    void Update()
    {
        if (killObject)
        {
            Destroy(gameObject, 2f);
        }
    }

}
