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

    // 회원가입 버튼 클릭 시 이벤트
    public void OnClickRegister()
    {
        NickName = NickNameInput.text;

        // 닉네임 영구적으로 저장
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

        // 유저 씬으로 이동
        SceneManager.LoadScene("UserScene");
    }

}
