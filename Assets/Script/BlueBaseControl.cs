using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueBaseControl : MonoBehaviour
{
    [SerializeField] Image HpGauge;

    [HideInInspector] public static BlueBaseControl Instance;

    // �� �ִ� ü��
    float MaxBaseHp = 3000f;
    // �� ���� ü��
    float CurrentBaseHp = 0;

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
    }
}
