using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour{


    // Detecta Trigers
    private void OnTriggerEnter2D(Collider2D collision){
        Destroy(transform.parent.gameObject);
        ScoreManager.scoreManager.RaiseScore(1);
        //gameObject.GetComponent<AudioSource>().Play();
    }
}
