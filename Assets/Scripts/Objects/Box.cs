using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public float lifePoints = 10f;

    public void Update()
    {
        if (lifePoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
