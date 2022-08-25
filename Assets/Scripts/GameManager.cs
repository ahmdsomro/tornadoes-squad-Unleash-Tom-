using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public GameObject scoreTextObject;
    public GameOverScreen GameOverScreen;
    public GameSuccessScreen GameSuccessScreen;

    int score;
    Text scoreText;


     void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance !=null)
            Destroy(gameObject);

        scoreText = scoreTextObject.GetComponent<Text>();

        scoreText.text = "Score: " + score.ToString();
        
    }

    public void Collect(int passedValue,GameObject passedObject)
    {
        Destroy(passedObject);
        score = score + passedValue;
        scoreText.text = "Score: " + score.ToString();

    }

    public void GameOver()
    {
        GameOverScreen.Setup(score);
    }

    public void GameSuccess()
    {
        GameSuccessScreen.Setup(score);
    }
}
