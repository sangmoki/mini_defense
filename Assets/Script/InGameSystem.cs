using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameSystem : MonoBehaviour
{
    [SerializeField] Text CoinText;
    [SerializeField] Button[] CharBtns;
    [SerializeField] Image[] CoinImages;
    [SerializeField] Image[] UnitImages;

    int[] CharNums;

    // Start is called before the first frame update
    void Start()
    {
        CharNums = new int[5];

        for (int i = 0; i < 5; i++)
        {
            CharNums[i] = PlayerPrefs.GetInt("Unit" + (i + 1));
        }

        StartCoroutine(CoinIncrease());
    }

    // Update is called once per frame
    void Update()
    {
        // ĳ���� ���� ���� Ȯ�� (�������� �����ߴ���)
        for (int i = 0; i < 5; i++)
        {
            if (CharNums[i] == 1)
            {
                // �ִٸ� ��ư Ȱ��ȭ
                CharBtns[i].interactable = true;
                UnitImages[i].color = Color.white;
                CoinImages[i].color = Color.white;
            }
            else if (CharNums[i] == 0)
            {
                // ���ٸ� ��ư ��Ȱ��ȭ
                CharBtns[i].interactable = false;
                UnitImages[i].color = Color.gray;
                CoinImages[i].color = Color.gray;
            }
        }

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
