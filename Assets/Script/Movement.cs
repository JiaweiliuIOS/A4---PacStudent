using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1.0f;
    private Vector2 direction = Vector2.zero;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        input();
        move();
    }

    void input(){
        
        if (Input.GetKeyDown (KeyCode.D)){
            direction = Vector2.right;

        }else if (Input.GetKeyDown (KeyCode.A)){
            direction = Vector2.left;

        }else if (Input.GetKeyDown (KeyCode.W)){
            direction = Vector2.up;

        }else if (Input.GetKeyDown (KeyCode.S)){
            direction = Vector2.down;
        }

        //Animation connected
        //Vector2 dir = direction - (Vector2)transform.position;
        //GetComponent<Animator>().SetFloat("DirX", dir.x);
        //GetComponent<Animator>().SetFloat("DirY", dir.y);
    }
    void move(){
        transform.localPosition += (Vector3)(direction * speed) * Time.deltaTime;
    }
}
