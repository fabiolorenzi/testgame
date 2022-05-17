using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Animator player_anim;
    private AudioSource audioController;

    [SerializeField]
    private AudioClip attackSound;

    public void Awake()
    {
        player_anim = GetComponentInChildren<Animator>();
        audioController = GetComponentInChildren<AudioSource>();
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            player_anim.SetTrigger("Attack");
            audioController.clip = attackSound;
            audioController.Play();
        }
    }
}
