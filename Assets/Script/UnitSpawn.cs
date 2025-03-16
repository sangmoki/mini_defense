using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSpawn : MonoBehaviour
{
    [SerializeField] int UnitNumber;
    [SerializeField] UnitObject[] UnitObjects;
    [SerializeField] Transform SpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ClickUnitSpawn()
    {
        GameObject unit = Instantiate(UnitObjects[UnitNumber - 1].UnitPrefab, SpawnPoint.position, SpawnPoint.rotation);
    }

}
