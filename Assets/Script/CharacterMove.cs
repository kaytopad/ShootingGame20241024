using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    //���s���x
    private float speed = 0.05f;
    //��]���x
    private float rotateSpeed = 0.3f;
    //�����A����
    Animator animator;
    //�A�j���[�V�����I�u�W�F�N�g
    private float horizonralInput, verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizonralInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        if (verticalInput != 0)
        {
            transform.position += transform.forward * speed * verticalInput;
            animator.SetBool("Walk", true);
        }
        else 
        { 
            animator.SetBool("Walk", false);
        }

        transform.Rotate(new Vector3(0, rotateSpeed * horizonralInput, 0));
    }
}
