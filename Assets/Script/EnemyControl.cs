using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    [SerializeField] EnemyObject enemyObject;

    private float speed = 1.5f;
    private bool isCollision = false;
    private float EnemyAttack = 0;

    Animator animator;

    // 오브젝트가 생성 될 때 초기화 하는 함수
    private void OnEnable()
    {
        EnemyAttack = 0;
    }

    void Start()
    {
        animator = GetComponent<Animator>();

        if (PlayerPrefs.GetInt("StageNumber") == 1)
        {
            EnemyAttack = enemyObject.EnemyAttack;
        }
        else if (PlayerPrefs.GetInt("StageNumber") == 2)
        {
            EnemyAttack = enemyObject.EnemyAttack + 10;
        }
    }

    void FixedUpdate()
    {
        if (!isCollision)
        {
            transform.Translate(Vector2.right * -(speed) * Time.deltaTime);
            animator.SetFloat("EnemyStatus", 0.5f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BaseBlue")
        {
            isCollision = true;
            StartCoroutine(EnemyBaseAttackCoroutine());
        }
    }

    IEnumerator EnemyBaseAttackCoroutine()
    {
        while (true)
        {
            animator.SetFloat("EnemyStatus", 1f);
            BlueBaseControl.Instance.TakeDamage(EnemyAttack);
            yield return new WaitForSeconds(0.25f);

            animator.SetFloat("EnemyStatus", 0.5f);
            yield return new WaitForSeconds(1.5f);
        }
    }
}
