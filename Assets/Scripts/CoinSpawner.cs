using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour{
    
    float timer;
    public GameObject coinPrefab;

    //Se actualisa en cada frame
    void Update(){
        timer += Time.deltaTime;

        if (timer >= 2f){
            timer = 0;
            float x = Random.Range(-30f, 30f);
            float y = Random.Range(0, 2.5f);
            Vector3 position = new Vector3(x, y, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(coinPrefab, position, rotation);
        }
    }
}
