using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitControl : MonoBehaviour
{
    private float speed = 1.5f;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        animator.SetFloat("Status", 0.5f);
    }
}
