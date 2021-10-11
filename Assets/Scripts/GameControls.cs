using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControls : MonoBehaviour{
    
    //Carga ecenas
    public void LoadScene(string sceneName){
        SceneManager.LoadScene(sceneName);
        string scene = sceneName;
        Debug.Log("Se ah ido a " + scene);
    }

    //Te saca del juego
    public void Exit(){
        Debug.Log("NaturalLapse por RedPandaGames");
        Debug.Log("(ReisyRedPanda)");
        Application.Quit();
        Debug.Log("Se ah salido del Juego");
    }
}
