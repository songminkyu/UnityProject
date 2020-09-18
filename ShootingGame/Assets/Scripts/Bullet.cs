using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //필요 속성 : 이동 속도
    public float speed = 5;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //1. 방향을 구한다.
        Vector3 dir = Vector3.up;

        //2. 이동을 하고 싶다. 공식 P = P0 + vt;

        transform.position += dir * speed * Time.deltaTime;
                        
    }
}
