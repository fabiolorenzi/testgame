using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFootsteps : MonoBehaviour
{
    private AudioSource footstep_sound;

    [SerializeField]
    private AudioClip[] footstep_clip;

    private CharacterController character_controller;

    [HideInInspector]
    public float volume_min, volume_max;

    private float accumulate_distance;

    [HideInInspector]
    public float steps_distance;

    public void Awake()
    {
        footstep_sound = GetComponent<AudioSource>();
        character_controller = GetComponentInParent<CharacterController>();
    }

    public void Update()
    {
        CheckToPlaySound();
    }

    public void CheckToPlaySound()
    {
        if (!character_controller.isGrounded)
        {
            return;
        }

        if (character_controller.velocity.sqrMagnitude > 0)
        {
            accumulate_distance += Time.deltaTime;

            if (accumulate_distance > steps_distance)
            {
                footstep_sound.volume = Random.Range(volume_min, volume_max);
                footstep_sound.clip = footstep_clip[0];
                footstep_sound.Play();
            }
        }
        else
        {
            accumulate_distance = 0f;
        }
    }
}
