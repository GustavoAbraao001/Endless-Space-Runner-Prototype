using UnityEngine;

public class LimitDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Ambient"))
        {
            Destroy(other.gameObject);
        }
            
        
    }
}
