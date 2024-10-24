using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    float speed = 3.0f;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            animator.SetBool("Walk",true);
            
        }
        if (Input.GetKey(KeyCode.DownArrow)) 
        { 
            transform.position -= transform.forward * speed * Time.deltaTime;
            animator.SetBool("Walk", true);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
            animator.SetBool("Walk", true);
        }
        if (Input.GetKey(KeyCode.RightArrow)) 
        { 
            transform.position += transform.right * speed * Time.deltaTime;
            animator.SetBool("Walk", true);
        }

        if(Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetBool("Walk", false);
        }
    }
}
