using UnityEngine;

public class PistolBehavior : MonoBehaviour
{
    public GameObject laserTemplate;
    public Transform spawnPoint; 
    public int clipSize = 6;
    private int shotsRemaining; 

    void Start()
    {
        shotsRemaining = clipSize;
    }

    public void ShootLaser()
    {
        if (shotsRemaining > 0)
        {
            GameObject laser = Instantiate(laserTemplate, spawnPoint.position, spawnPoint.rotation);
            Rigidbody laserRb = laser.GetComponent<Rigidbody>();
            laserRb.AddForce(spawnPoint.forward * 500f);

            shotsRemaining--;
            Debug.Log("Shots remaining: " + shotsRemaining);
        }
        else
        {
            Debug.Log("Out of ammo! Place the gun on the pedestal to reload.");
        }
    }

    public void Reload()
    {
        shotsRemaining = clipSize;
        Debug.Log("Gun reloaded! Shots available: " + shotsRemaining);
    }
}

