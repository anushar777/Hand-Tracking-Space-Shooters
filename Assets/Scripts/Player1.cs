using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class Player1 : MonoBehaviour
{
    public float yPos;
    [SerializeField] GameObject laser;
    [SerializeField] float spawnRate = 2f; // spawnrate
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        yPos = transform.position.y;//Grabs starting y pos
        InvokeRepeating("SpawnLaser", 1f, spawnRate); // Calls SpawnEnemy every spawnRate seconds
    }

    // Update is called once per frame
    void Update()
    {
        

        
        //Instantiate(laser, transform.position, Quaternion.identity)




    }
    void SpawnLaser()
    {
        Instantiate(laser, transform.position, Quaternion.identity);
    }
}
