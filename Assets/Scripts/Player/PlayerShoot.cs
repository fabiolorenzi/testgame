using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public float damage = 5f;
    public float range = 50f;
    public float bpm = 60f;
    private float time = 0f;

    public Camera fpsCam;

    private AudioSource audioController;

    [SerializeField]
    private AudioClip sound;
    private Animator player_anim;

    public void Start()
    {
        audioController = GetComponentInChildren<AudioSource>();
        player_anim = GetComponentInChildren<Animator>();
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            if (Time.time >= time)
            {
                Shoot();
                time += 60 / bpm;
            }
        }
    }

    public void Shoot()
    {
        RaycastHit hit;

        // the code below is returning true if we touch something with the ray we create
        player_anim.SetTrigger("Shoot");
        audioController.clip = sound;
        audioController.Play();

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            if (hit.transform.tag == "Box")
            {
                Box boxScript = hit.transform.GetComponent<Box>();
                boxScript.lifePoints -= damage;
            }
        }
    }
}
