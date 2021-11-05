using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliders : MonoBehaviour
{
    private Rigidbody2D playerRigidbody2D;
    private Vector3 movedir;

    private void Awake(){
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate(){
        //playerRigidbody2D.MovePosition(transform.position + movedir * SPEED * Time.fixedDeltaTime);
    }

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("hit");
    }
}
