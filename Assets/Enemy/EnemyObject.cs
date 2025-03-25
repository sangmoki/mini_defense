using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyObject", menuName = "EnemyObject/ScriptableObject")]
public class EnemyObject : ScriptableObject
{
    public GameObject EnemyPrefab;
    public float EnemyAttack;
}
