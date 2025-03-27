using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueBaseControl : MonoBehaviour
{
    [SerializeField] GameObject BlackPanel;
    [SerializeField] GameObject GameOverPanel;
    [SerializeField] Text GameOverText;
    [SerializeField] Image HpGauge;

    [HideInInspector] public static BlueBaseControl Instance;

    // 성 최대 체력
    float MaxBaseHp = 3000f;
    // 성 현재 체력
    float CurrentBaseHp = 0;
    int RewardCoin = 300;
    int CurrentCoin = 0;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        // 성 체력 초기화
        CurrentBaseHp = MaxBaseHp;
    }

    void Update()
    {
        // 성 체력 감소
        // Clamp01 : 0 ~ 1 사이의 값으로 제한
        HpGauge.fillAmount = Mathf.Clamp01(CurrentBaseHp / MaxBaseHp);
    }

    // 성 체력 감소 연산
    public void TakeDamage(float Damage)
    {
        CurrentBaseHp -= Damage;

        if (CurrentBaseHp <= 0)
        {
            BlackPanel.SetActive(true);
            GameOverPanel.SetActive(true);
            GameOverText.text = "게임에서 패배하셨습니다.";

            CurrentCoin = PlayerPrefs.GetInt("Coin");
            PlayerPrefs.SetInt("Coin", CurrentCoin + RewardCoin);
            PlayerPrefs.Save();

            Time.timeScale = 0;
        }
    }
}
