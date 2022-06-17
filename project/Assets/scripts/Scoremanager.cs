using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoremanager : MonoBehaviour
{
    public static Scoremanager instance;

    public Text scoretext;
    public Text highscoreText;



    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;        
    }


    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("HighScore", 0);
        scoretext.text = "Score:" + score.ToString(); 
        highscoreText.text = "HIGHSCORE:" + highscore.ToString();

    }
     public void AddPoints()
    {
        score += 1;
        scoretext.text = "Score:" + score.ToString();
        if (highscore < score)
         
            PlayerPrefs.SetInt("HighScore", score);
       // PlayerPrefs.DeleteAll();

    }
    
}
