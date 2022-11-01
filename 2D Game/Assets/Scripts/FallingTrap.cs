using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTrap : MonoBehaviour
{
    [SerializeField] float fallTime = 1.0f, destroyTime = 2.0f;   //인스펙터에서 접근 가능
    Rigidbody2D rigidbody2D;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")   //Plyer 콜라이더 접촉시
        {
            Invoke("FallTrap", fallTime);   //함수 시작시간 늦추기
            Destroy(gameObject, destroyTime);
        }
    }

    void FallTrap()
    {
        rigidbody2D.isKinematic = false;    //물리힘 동작
    }

    // Update is called once per frame
    void Update()
    {

    }
}