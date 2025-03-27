using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSpawn : MonoBehaviour
{
    [SerializeField] int UnitNumber;
    [SerializeField] UnitObject[] UnitObjects;
    [SerializeField] Transform SpawnPoint;

    [HideInInspector] public static int CoinAmount = 100;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void ClickUnitSpawn(int Cost)
    {
        // 만약 코인이 유닛의 가격보다 크거나 같다면
        if (Cost <= CoinAmount)
        {
            // 유닛 생성
            GameObject unit = Instantiate(UnitObjects[UnitNumber - 1].UnitPrefab, SpawnPoint.position, SpawnPoint.rotation);
            // 코인 감소
            CoinAmount -= Cost;
        }

    }

}
