using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    private static Slider slider;

    public void Awake()
    {
        slider = GetComponent<Slider>();
    }

    public static void UpdateLife(float points)
    {
        slider.value = points / 10f;
    }
}
