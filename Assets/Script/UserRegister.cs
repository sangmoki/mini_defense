using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UserRegister : MonoBehaviour
{
    [SerializeField]
    InputField NickNameInput;

    string NickName;

    void Start()
    {
        
    }

    // ȸ������ ��ư Ŭ�� �� �̺�Ʈ
    public void OnClickRegister()
    {
        NickName = NickNameInput.text;

        // �г��� ���������� ����
        PlayerPrefs.SetString("UserNickName", NickName);

        PlayerPrefs.SetInt("Coin", 1000);
        PlayerPrefs.SetInt("Level", 1);
        PlayerPrefs.SetInt("MinCount", 0);

        for (int i = 1; i < 4; i++)
        {
            PlayerPrefs.SetInt("Unit" + i, 1);
        }
        PlayerPrefs.SetInt("Unit4", 0);
        PlayerPrefs.SetInt("Unit5", 0);

        PlayerPrefs.Save();

        // ���� ������ �̵�
        SceneManager.LoadScene("UserScene");
    }

}
