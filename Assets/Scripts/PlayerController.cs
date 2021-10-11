using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour {
    bool canJump;

    //Salto
    public void Jump() {
        if (canJump) {
            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 250f));
        }
    }

    //Izquierda
    public void left() {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-500f * Time.deltaTime, 0));
        gameObject.GetComponent<Animator>().SetBool("moving", true);
        gameObject.GetComponent<SpriteRenderer>().flipX = true;
    }

    //Derecha
    public void right() {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(500f * Time.deltaTime, 0));
        gameObject.GetComponent<Animator>().SetBool("moving", true);
        gameObject.GetComponent<SpriteRenderer>().flipX = false;
    }

    //Se actualisa en cada frame
    void Update(){
        //Mover a la izquierda
        if(Input.GetKey("left")){
            left();
        }

        //Mover a la derecha
        if(Input.GetKey("right")){
            right();
        }
        //saltar
        if(Input.GetKeyDown("up")){
            Jump();
        }
        if(!Input.GetKey("left") && !Input.GetKey("right")){
            gameObject.GetComponent<Animator>().SetBool("moving", false);
        }
    }

    //Detectar colisiones
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.transform.tag == "ground"){
            canJump = true;
        }
    }
}
