using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveFill : MonoBehaviour
{
    public void Update()
    {
        if (PlayerLife.lifePoints <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
