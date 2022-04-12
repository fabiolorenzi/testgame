using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController character_controller;
    private Vector3 move_directions;
    public float speed = 4f;
    private float gravity = 20f;
    public float jump_force = 7f;
    private float vertical_velocity;

    private Animator player_anim;

    [SerializeField]
    private Transform playerBody;

    public void Awake()
    {
        character_controller = GetComponent<CharacterController>();
        player_anim = GetComponentInChildren<Animator>();
    }

    public void Update()
    {
        MovePlayer();
        PlayerJump();
    }

    public void MovePlayer()
    {
        move_directions = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        
        // this code below is to understand if the player is walking and so play an animation or another one
        if (move_directions.x != 0f || move_directions.y != 0f || move_directions.z != 0f)
        {
            player_anim.SetBool("isWalking", true);
        }
        else
        {
            player_anim.SetBool("isWalking", false);
        }

        move_directions = transform.TransformDirection(move_directions * speed * Time.deltaTime);

        ApplyGravity();
        character_controller.Move(move_directions);
        playerBody.position = transform.position;
    }

    public void ApplyGravity()
    {
        vertical_velocity -= gravity * Time.deltaTime;
        move_directions.y = vertical_velocity * Time.deltaTime; 
    }

    public void PlayerJump()
    {
        if (character_controller.isGrounded && Input.GetKey(KeyCode.Space))
        {
            vertical_velocity = jump_force;
        }
    }
}
