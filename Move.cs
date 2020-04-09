using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//参考文献
//https://gametukurikata.com/program/unityprogramming

public class Move : MonoBehaviour
{

    private CharacterController characterController;
    private Vector3 velocity;
    [SerializeField]
    private float walkSpeed;

    // Use this for initialization
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (characterController.isGrounded)
        {
            velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        }
        velocity.y += Physics.gravity.y * Time.deltaTime;
        characterController.Move(velocity * walkSpeed * Time.deltaTime);
    }
}
