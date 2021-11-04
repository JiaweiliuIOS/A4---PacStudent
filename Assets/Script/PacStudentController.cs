using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    public float speed = 1.0f;
    private Vector3 direction = Vector2.zero;
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
        currentInput();
    }

    void lastInput(){
        
        if (Input.GetKeyDown (KeyCode.D)){
            direction = Vector2.right;
            Controller.SetTrigger("Right");
            createDust();

        }else if (Input.GetKeyDown (KeyCode.A)){
            direction = Vector2.left;
            Controller.SetTrigger("Left");
            createDust();

        }else if (Input.GetKeyDown (KeyCode.W)){
            direction = Vector2.up;
            Controller.SetTrigger("Up");
            createDust();

        }else if (Input.GetKeyDown (KeyCode.S)){
            direction = Vector2.down;
            Controller.SetTrigger("Down");
            createDust();
            }
    }
    void currentInput(){
        transform.localPosition += (Vector3)(direction * speed) * Time.deltaTime;
    }
    void createDust(){
        dust.Play();
    }

}
