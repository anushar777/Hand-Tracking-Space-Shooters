using UnityEditor.Build.Content;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float enemySpeedY = 0.05f; // Speed of the enemyY in meters per second
    [SerializeField] Manager gameManager; // Reference to the GameManager script
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += new Vector3(0, -enemySpeedY, 0) * Time.deltaTime; // Moves the enemy down at a speed of 0.05 meters per second
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") // Checks if the enemy collides with the player
        {
            Manager.instance.GameOver(); // Calls the GameOver method in the Manager class
        }
        else
        {
            Manager.instance.AddScore(1); // Adds 1 point to the score when the enemy collides with the laser
      

        }
        Destroy(gameObject);
        Destroy(collision.gameObject);


    }
}
