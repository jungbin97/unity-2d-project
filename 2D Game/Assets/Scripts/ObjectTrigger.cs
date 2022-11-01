using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTrigger : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            this.gameObject.SetActive(false);   //덩쿨 제거 오브젝트 비활성화
            DestroySpike();
        }
    }

    void DestroySpike()     //덩쿨 제거 함수
    {
        GameObject[] spikes = GameObject.FindGameObjectsWithTag("Spike");   //spike 태그 가진 오브젝트 찾기
        for (int i = 0; i < spikes.Length; i++)
        {
            Destroy(spikes[i]); //파괴
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
