using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTrap : MonoBehaviour
{
    [SerializeField] float fallTime = 1.0f, destroyTime = 2.0f;   //�ν����Ϳ��� ���� ����
    Rigidbody2D rigidbody2D;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")   //Plyer �ݶ��̴� ���˽�
        {
            Invoke("FallTrap", fallTime);   //�Լ� ���۽ð� ���߱�
            Destroy(gameObject, destroyTime);
        }
    }

    void FallTrap()
    {
        rigidbody2D.isKinematic = false;    //������ ����
    }

    // Update is called once per frame
    void Update()
    {

    }
}