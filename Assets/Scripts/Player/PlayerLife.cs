using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    private int lifePoints = 10;

    public void Start()
    {
        Life.UpdateLife(10);
    }
}
