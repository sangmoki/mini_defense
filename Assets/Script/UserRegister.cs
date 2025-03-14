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
        PlayerPrefs.Save();

        // 유저 씬으로 이동
        SceneManager.LoadScene("UserScene");
    }

}
