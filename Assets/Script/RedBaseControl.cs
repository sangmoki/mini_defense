using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedBaseControl : MonoBehaviour
{
    [SerializeField] Image HpGauge;

    [HideInInspector] public static RedBaseControl Instance;

    // 성 최대 체력
    float MaxBaseHp = 3000f;
    // 성 현재 체력
    float CurrentBaseHp = 0;

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
    }
}
