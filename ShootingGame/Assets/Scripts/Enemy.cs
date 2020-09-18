using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 아래로 계속 이동 하고 싶다!.
// 필요속성 : 속도
// 적이 다른 물체와 충돌 하면 죽을떄 폭발 효과를 나타나게 하고 싶다.
public class Enemy : MonoBehaviour
{
    // 필요속성 : 속도
    public float speed = 5;
    // Start is called before the first frame update
    Vector3 dir;
    // 필요 속성 : 총알 공장 필요.
    public GameObject explosionFactory;

    void Start()
    {       
        int randValue = UnityEngine.Random.Range(0, 10);
      
        if(randValue < 3)
        {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - transform.position;
            dir.Normalize();           
        }
        else
        {
            dir = Vector3.down;
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        // 아래로 계속 이동 하고 싶다!.
        // 1. 아래로 방향을 만든다.       
        // 2. 이동하고 싶다.
        // P = P0 + vt;
        transform.position += dir * speed * Time.deltaTime;
    }

    //다른 충돌체와 부딛혔을때 상대방 죽고, 본인도 죽는 시나리오.

   
    private void OnCollisionEnter(Collision other)//충돌시작
    {
        // 적이 다른 물체와 충돌 하면 죽을떄 폭발 효과를 나타나게 하고 싶다.
        // 필요 속성 : 총알 공장 필요.

        // 1. 폭발효과 만들어야 한다. (폭발 효과 공장에서)
        GameObject explosion = Instantiate(explosionFactory);

        // 2. 폭발효과 배치 하고 싶다.
        explosion.transform.position = transform.position;

        //상대방 객차 파괴
        Destroy(other.gameObject);
      
        //내 객체 파괴
        Destroy(gameObject);
       
    }

}
