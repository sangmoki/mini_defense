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
        // 캐릭터 보유 여부 확인 (상점에서 구매했는지)
        for (int i = 0; i < 5; i++)
        {
            if (CharNums[i] == 1)
            {
                // 있다면 버튼 활성화
                CharBtns[i].interactable = true;
                UnitImages[i].color = Color.white;
                CoinImages[i].color = Color.white;
            }
            else if (CharNums[i] == 0)
            {
                // 없다면 버튼 비활성화
                CharBtns[i].interactable = false;
                UnitImages[i].color = Color.gray;
                CoinImages[i].color = Color.gray;
            }
        }

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
