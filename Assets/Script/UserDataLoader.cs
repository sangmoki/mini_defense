using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserDataLoader : MonoBehaviour
{
    [SerializeField] Text UserNickNameText;
    [SerializeField] Button[] CharBtns;
    [SerializeField] Text WinText;

    int[] CharNum;

    void Start()
    {
        CharNum = new int[5];

        for (int i = 0; i < 5; i++)
        {
            CharNum[i] = PlayerPrefs.GetInt("Unit" + (i + 1));
        }
    }

    void Update()
    {
        UserNickNameText.text = PlayerPrefs.GetString("UserNickName");
        WinText.text = "�¸� Ƚ�� : " + PlayerPrefs.GetInt("WinCount").ToString();

        for (int i = 0; i < 5; i++)
        {
            if (CharNum[i] == 1)
            {
                // ĳ���� Ȱ��ȭ
                CharBtns[i].interactable = true;
            }
            else if (CharNum[i] == 0)
            {
                // ĳ���� ��Ȱ��ȭ
                CharBtns[i].interactable = false;
            }
        }
    }
}
