using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTrigger : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            this.gameObject.SetActive(false);   //���� ���� ������Ʈ ��Ȱ��ȭ
            DestroySpike();
        }
    }

    void DestroySpike()     //���� ���� �Լ�
    {
        GameObject[] spikes = GameObject.FindGameObjectsWithTag("Spike");   //spike �±� ���� ������Ʈ ã��
        for (int i = 0; i < spikes.Length; i++)
        {
            Destroy(spikes[i]); //�ı�
        }

    }

    /**********************************************
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    ************************************************/
}
