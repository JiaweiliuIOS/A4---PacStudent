using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    public float speed = 1.0f;
    private Vector3 direction = Vector3.zero;
    Animator Controller;
    public ParticleSystem dust;

    public int pallet = 10;

    // Start is called before the first frame update
    void Start()
    {
        Controller = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        lastInput();
        move();
    }

    void lastInput(){
        
        if (Input.GetKeyDown (KeyCode.D)){
            direction = Vector3.right;
            Controller.SetTrigger("Right");
            createDust();

        }else if (Input.GetKeyDown (KeyCode.A)){
            direction = Vector3.left;
            Controller.SetTrigger("Left");
            createDust();

        }else if (Input.GetKeyDown (KeyCode.W)){
            direction = Vector3.up;
            Controller.SetTrigger("Up");
            createDust();

        }else if (Input.GetKeyDown (KeyCode.S)){
            direction = Vector3.down;
            Controller.SetTrigger("Down");
            createDust();
            }
    }
    void move(){
        transform.localPosition += (Vector3)(direction * speed) * Time.deltaTime;
    }
    void createDust(){
        dust.Play();
    }

}
