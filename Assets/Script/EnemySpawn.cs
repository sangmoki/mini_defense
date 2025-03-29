using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] EnemyObject[] enemyObjects;
    [SerializeField] Transform SpawnPoint;

    void Start()
    {
        StartCoroutine(EnemySpawnCoroutine());
    }

    IEnumerator EnemySpawnCoroutine()
    {
        if (PlayerPrefs.GetInt("StageNumber") == 1)
        {
            while (true)
            {
                for (int i = 0; i < Random.Range(3, 5); i++)
                {
                    int index = Random.Range(0, 3);
                    GameObject enemy = Instantiate(enemyObjects[index].EnemyPrefab, SpawnPoint.position, SpawnPoint.rotation);
                    yield return new WaitForSeconds(0.7f);
                }
                yield return new WaitForSeconds(10f);
            }
        }
        else if (PlayerPrefs.GetInt("StageNumber") == 2)
        {
            while (true)
            {
                for (int i = 0; i < Random.Range(3, 6); i++)
                {
                    int index = Random.Range(0, 5);
                    GameObject enemy = Instantiate(enemyObjects[index].EnemyPrefab, SpawnPoint.position, SpawnPoint.rotation);
                    yield return new WaitForSeconds(0.7f);
                }
                yield return new WaitForSeconds(10f);
            }
        }
    }
}
