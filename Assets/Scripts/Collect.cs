using UnityEngine;

public class Collect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // increase score
        
        Destroy(gameObject);
    }
}
