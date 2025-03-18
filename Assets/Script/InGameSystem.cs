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

    // ���� ���� (1�ʸ��� 10�� ����)
    IEnumerator CoinIncrease()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            UnitSpawn.CoinAmount += 10;
        }

    }
}
