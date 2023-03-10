using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public Text scoreText;
    public int score;

    public static GameManager Instance {
        get {
            if(instance==null) {
                instance = new GameManager();
            }
 
            return instance;
        }
    }
    
 
    void Awake()
    {
        instance = this;
    }
 
    public void UpdateScore()
    {
        score++;
        if (score == 10)
        {
            SceneManager.LoadScene(0);
        }
        scoreText.text = "Score: " + score;
    }
}
