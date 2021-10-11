using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour{

    public static ScoreManager scoreManager;

    public Text scoreText;   
    int score = 0;

    //Se actualisa al iniciar el juego
    void Start(){
        if(scoreManager == null){
            scoreManager = this;
            DontDestroyOnLoad(this);
        }
        else{
            Destroy(gameObject);
        }
    }

    void Update(){
        if(scoreText == null){
            scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
            scoreText.text = "Puntaje: " + score.ToString();
        }
        
    }

    //Puntaje
    public void RaiseScore(int s){
        score += s;
        Debug.Log("Puntaje: " + score);
        scoreText.text = "Puntaje: " + score.ToString();

        if(score == 5){
            SceneManager.LoadScene("TNV2");
        }
    }
}
