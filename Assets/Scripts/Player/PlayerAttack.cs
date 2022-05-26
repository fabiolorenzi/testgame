using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField]
    private float damage = 10f;

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

    public void OnControllerColliderHit(ControllerColliderHit collision)
    {
        if (player_anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
        {
            if (collision.gameObject.name == "Box")
            {
                Box boxScript = collision.gameObject.GetComponent<Box>();
                boxScript.lifePoints -= damage;
            }
        }
    }
}
