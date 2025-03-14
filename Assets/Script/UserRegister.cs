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
        PlayerPrefs.Save();

        // ���� ������ �̵�
        SceneManager.LoadScene("UserScene");
    }

}
