using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public static float lifePoints = 10;

    public void Start()
    {
        Life.UpdateLife(lifePoints);
    }
}
