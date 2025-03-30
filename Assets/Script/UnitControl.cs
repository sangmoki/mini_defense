using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitControl : MonoBehaviour
{
    // ScriptableOjbect ���� ���� ����
    [SerializeField] UnitObject unitObject;

    // ���� �̵��ӵ�
    private float speed = 1.5f;
    // �浹 ����
    private bool isCollision = false;
    // ���� ���ݷ�
    private float UnitAttack = 0;

    private int Level = 0;

    Animator animator;

    // �⺻���ݷ� + (5 x (Level - 1))
    // �������� ��ȭ �� Level�� 1�� ����

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
        // �浹�� �Ͼ�� ���� ��쿡 ���� �̵�
        if (!isCollision)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            animator.SetFloat("Status", 0.5f);
        }

    }

    // �浹 ���� Ȯ��
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // BaseRed�� �浹�� ���
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
