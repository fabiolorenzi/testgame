using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public static float lifePoints = 10;
    public Animator player_anim;
    public static bool isDead = false;

    public void Awake()
    {
        player_anim = GetComponentInChildren<Animator>();
    }

    public void Start()
    {
        Life.UpdateLife(lifePoints);
    }

    public void Update()
    {
        Life.UpdateLife(lifePoints);
        if (lifePoints <= 0)
        {
            isDead = true;
            player_anim.SetBool("isDead", true);
        }
    }
}
