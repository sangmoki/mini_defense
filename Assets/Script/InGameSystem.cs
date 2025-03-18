using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameSystem : MonoBehaviour
{
    [SerializeField] Text CoinText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CoinIncrease());
    }

    // Update is called once per frame
    void Update()
    {
        CoinText.text = UnitSpawn.CoinAmount.ToString();
    }

    // 코인 증가 (1초마다 10씩 증가)
    IEnumerator CoinIncrease()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            UnitSpawn.CoinAmount += 10;
        }

    }
}
