using UnityEngine;

public class CollisionEvents : MonoBehaviour
{
    public AudioSource audioCollectFX; // Applied AudioSource component

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Collision function for use with applied Collider Components
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Coin"){
            audioCollectFX.Play();
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Coin"){
            Destroy(collision.gameObject);
        }
    }
}
