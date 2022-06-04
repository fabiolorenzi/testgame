using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewStats", menuName = "Character")]
public class test_SO : ScriptableObject
{
    public bool SetManually = false;
    public bool saveDataOnClose = false;
    public int maxHealth = 0;
    public int baseDamage = 0;
    public int baseResistance = 0;
}
