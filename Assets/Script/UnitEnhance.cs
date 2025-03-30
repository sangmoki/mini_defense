using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitEnhance : MonoBehaviour
{
    [SerializeField] int EnhancePrice;
    [SerializeField] GameObject AlarmPanel;
    [SerializeField] Text AlarmText;

    int CurrentCoin = 0;
    int Level = 0;

    // Start is called before the first frame update
    void Start()
    {
        CurrentCoin = PlayerPrefs.GetInt("Coin");
        Level = PlayerPrefs.GetInt("Level");
    }

    public void EnhanceBtn()
    {
        if (CurrentCoin < EnhancePrice)
        {
            AlarmPanel.SetActive(true);
            AlarmText.text = "강화 실패";
            return;
        }

        AlarmPanel.SetActive(true);
        AlarmText.text = "강화 성공";

        PlayerPrefs.SetInt("Coin", CurrentCoin - EnhancePrice);
        PlayerPrefs.SetInt("Level", Level + 1);

        PlayerPrefs.Save();
    }

}
