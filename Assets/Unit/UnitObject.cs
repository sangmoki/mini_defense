using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UnitObject", menuName = "UnitObject/ScriptableObject")]
public class UnitObject : ScriptableObject
{
    public string UnitName;
    public Sprite UnitImage;
    public GameObject UnitPrefab;
    public float UnitAttack;
    public float UnitHp;
}
