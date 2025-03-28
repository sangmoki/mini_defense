using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedBaseControl : MonoBehaviour
{
    [SerializeField] GameObject BlackPanel;
    [SerializeField] GameObject GameOverPanel;
    [SerializeField] Text GameOverText;
    [SerializeField] Image HpGauge;

    [HideInInspector] public static RedBaseControl Instance;

    // �� �ִ� ü��
    float MaxBaseHp = 3000f;
    // �� ���� ü��
    float CurrentBaseHp = 0;

    int RewardCoin = 300;
    int CurrentCoin = 0;
    int WinCount = 0;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        // �� ü�� �ʱ�ȭ
        CurrentBaseHp = MaxBaseHp;
    }

    void Update()
    {
        // �� ü�� ����
        // Clamp01 : 0 ~ 1 ������ ������ ����
        HpGauge.fillAmount = Mathf.Clamp01(CurrentBaseHp / MaxBaseHp);
    }

    // �� ü�� ���� ����
    public void TakeDamage(float Damage)
    {
        CurrentBaseHp -= Damage;

        if (CurrentBaseHp <= 0)
        {
            BlackPanel.SetActive(true);
            GameOverPanel.SetActive(true);
            GameOverText.text = "���ӿ��� �¸��ϼ̽��ϴ�.";

            CurrentCoin = PlayerPrefs.GetInt("Coin");
            WinCount = PlayerPrefs.GetInt("WinCount");
            PlayerPrefs.SetInt("Coin", CurrentCoin + RewardCoin);
            PlayerPrefs.SetInt("WinCount", WinCount + 1);
            PlayerPrefs.Save();

            Time.timeScale = 0;
        }
    }
}
