using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] float laserSpeed = 0.1f; // Speed of the laser in meters per second
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, laserSpeed, 0) * Time.deltaTime; // Moves the laser up at a speed of 0.1 meters per second

    }
}
