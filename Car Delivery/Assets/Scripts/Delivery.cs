using UnityEngine;
public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new(0, 1, (byte)0.4460943, 1);
    [SerializeField] Color32 noPackageColor = new(1, 1, 1, 1);

    private bool hasPackage = false;

    SpriteRenderer carSpriteRenderer;

    void Start(){
        carSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other){
        
        if(other.gameObject.CompareTag("Package") && !hasPackage){
            Destroy(other.gameObject);
            carSpriteRenderer.color = hasPackageColor;
            hasPackage = true;
        }

        if(other.gameObject.CompareTag("Costumer") && hasPackage){
            carSpriteRenderer.color = noPackageColor;
            hasPackage = false;
        }
    }
}
