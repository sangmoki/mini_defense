using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitControl : MonoBehaviour
{
    // ScriptableOjbect 유닛 변수 선언
    [SerializeField] UnitObject unitObject;

    // 유닛 이동속도
    private float speed = 1.5f;
    // 충돌 여부
    private bool isCollision = false;
    // 유닛 공격력
    private float UnitAttack = 0;

    private int Level = 0;

    Animator animator;

    // 기본공격력 + (5 x (Level - 1))
    // 상점에서 강화 시 Level이 1씩 증가

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        Level = PlayerPrefs.GetInt("Level");
        UnitAttack = unitObject.UnitAttack + (5 * (Level- 1));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // 충돌이 일어나지 않은 경우에 유닛 이동
        if (!isCollision)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            animator.SetFloat("Status", 0.5f);
        }

    }

    // 충돌 여부 확인
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // BaseRed에 충돌한 경우
        if (collision.gameObject.tag == "BaseRed")
        {
            isCollision = true;
            StartCoroutine(UnitBaseAttackCoroutine());
        }
    }

    IEnumerator UnitBaseAttackCoroutine()
    {
        while (true)
        {
            animator.SetFloat("Status", 1f);
            RedBaseControl.Instance.TakeDamage(UnitAttack);
            yield return new WaitForSeconds(0.25f);

            animator.SetFloat("Status", 0.5f);
            yield return new WaitForSeconds(1.5f);
        }
    }
}
