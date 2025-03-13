using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public bool destroyWithAnyObject = false;
    public string collisionTag = ""; 

    void OnCollisionEnter(Collision collision)
    {
        if (destroyWithAnyObject)
        {
            Debug.Log(gameObject.name + " destroyed on collision with " + collision.gameObject.name);
            Destroy(gameObject);
            return;
        }
        if (!string.IsNullOrEmpty(collisionTag) && collision.gameObject.CompareTag(collisionTag))
        {
            Debug.Log(gameObject.name + " destroyed by " + collision.gameObject.name);
            Destroy(gameObject);
        }
    }
}

