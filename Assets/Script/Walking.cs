using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    public float speed = 1.0f;
    private Vector2 direction = Vector2.zero;
    Animator Controller;

    // Start is called before the first frame update
    void Start()
    {
        Controller = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        input();
        move();
    }

    void input(){
        
        if (Input.GetKeyDown (KeyCode.D)){
            direction = Vector2.right;
            Controller.SetTrigger("Right");

        }else if (Input.GetKeyDown (KeyCode.A)){
            direction = Vector2.left;
            Controller.SetTrigger("Left");

        }else if (Input.GetKeyDown (KeyCode.W)){
            direction = Vector2.up;
            Controller.SetTrigger("Up");

        }else if (Input.GetKeyDown (KeyCode.S)){
            direction = Vector2.down;
            Controller.SetTrigger("Down");}
    }
    void move(){
        transform.localPosition += (Vector3)(direction * speed) * Time.deltaTime;
    }
}
