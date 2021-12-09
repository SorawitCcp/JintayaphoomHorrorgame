using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 1;
    float gravity = 1;

    Vector3 moveDirectory = Vector3.zero;

    CharacterController controller;
    Animator animator;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetInteger("RunCondition", 1);
                moveDirectory = new Vector3(0, 0, 2);
                moveDirectory *= speed;
                moveDirectory = transform.TransformDirection(moveDirectory);
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                animator.SetInteger("RunCondition", 0);
            }
            animator.SetInteger("WalkCondition", 1);
            moveDirectory = new Vector3(0, 0, 1);
            moveDirectory *= speed;
            moveDirectory = transform.TransformDirection(moveDirectory);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetInteger("WalkCondition", 0);
            animator.SetInteger("RunCondition", 0);
            moveDirectory = new Vector3 (0, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetInteger("WalkBackCondition", 1);
            moveDirectory = new Vector3(0, 0, -1);
            moveDirectory *= speed;
            moveDirectory = transform.TransformDirection(moveDirectory);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetInteger("WalkBackCondition", 0);
            moveDirectory = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveDirectory = new Vector3(-2, 0, 0);
            moveDirectory *= speed;
            moveDirectory = transform.TransformDirection(moveDirectory);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            moveDirectory = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDirectory = new Vector3(2, 0, 0);
            moveDirectory *= speed;
            moveDirectory = transform.TransformDirection(moveDirectory);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            moveDirectory = new Vector3(0, 0, 0);
        }
        moveDirectory.y -= gravity * Time.deltaTime;
        controller.Move(moveDirectory * Time.deltaTime);
    }
}
