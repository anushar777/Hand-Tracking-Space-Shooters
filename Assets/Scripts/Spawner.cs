using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    [SerializeField] float spawnRate= 2f; // spawnrate
    [SerializeField] GameObject enemyPrefab; // Prefab to spawn
    

    //coords
    float xMin;
    float xMax;
    float yPos;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        xMin = Camera.main.ViewportToWorldPoint(new Vector3(0.1f, 0, 0)).x; // Gets the minimum x coordinate of the camera view
        xMax = Camera.main.ViewportToWorldPoint(new Vector3(0.9f, 0, 0)).x; // Gets the maximum x coordinate of the camera view
        yPos = Camera.main.ViewportToWorldPoint(new Vector3(0, 1.25f, 0)).y; // Sets the y position slightly above the camera view
        InvokeRepeating("SpawnEnemy", 1f, spawnRate); // Calls SpawnEnemy every spawnRate seconds
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy()
    {
        float x =  Random.Range(xMin, xMax);
        Instantiate(enemyPrefab, new Vector3(x, yPos, 0), Quaternion.identity); // Instantiates an enemy at the spawner's position with no rotation
        
    }
}
