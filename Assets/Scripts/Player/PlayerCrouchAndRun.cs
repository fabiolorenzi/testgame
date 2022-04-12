using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrouchAndRun : MonoBehaviour
{
    private PlayerMovement player_movement;
    private Transform lookRoot;

    public float sprint_speed = 9f;
    public float move_speed = 4f;
    public float crouch_speed = 1.5f;

    private float standHeight = 1.6f;
    private float crouchHeight = 1f;

    private bool is_crouching;

    private PlayerFootsteps player_footsteps;

    private float sprint_volume = 1f;
    private float crouch_volume = 0.1f;
    private float walk_volume_min = 0.2f;
    private float walk_volume_max = 0.6f;

    private float walk_steps_distance = 0.4f;
    private float sprint_steps_distance = 0.25f;
    private float crouch_steps_distance = 0.5f;

    public void Awake()
    {
        player_movement = GetComponent<PlayerMovement>();
        player_footsteps = GetComponentInChildren<PlayerFootsteps>();
        lookRoot = transform.GetChild(0);
    }
}
