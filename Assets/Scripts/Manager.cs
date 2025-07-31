using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    int score = 0;
    public static Manager instance; // Singleton instance of the Manager class
    [SerializeField] TextMeshProUGUI scoreText; // Reference to the UI Text component to display the score
    [SerializeField] GameObject gameOverText; // Reference to the UI Text component to display the game over message

    bool gameOver = false; 

    private void Awake()
    { 
        instance = this; // Assigns the instance if it is null
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit") && gameOver)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void AddScore(int points)
    {
        score += points; // Adds points to the score
        scoreText.text = "Score: " + score; // Updates the UI Text component to display the new score
    }
    public void GameOver()
    {
        gameOver = true; // Sets the game over state to true
        gameOverText.SetActive(true); // Activates the game over UI Text component
        
    }
}
