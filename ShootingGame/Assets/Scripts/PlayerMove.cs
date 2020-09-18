using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed = 5;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //사용자의 입력을 받아서 이동하고 싶다.
        // 1. 사용자의 입력에 따라서
        // - 좌우 입력 받기 A,D 키
        // 왼쪽키를 누르면 -1, 오른쪽키를 누르면 +1

        
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //2. 방향이 필요
        Vector3 dir = new Vector3(h, v, 0);
        //3. 이동하고 싶다.
        //transform.Translate(dir * speed * Time.deltaTime);
        // P = P0 + vt (미래 = 현재위치 + 이동할 크기 * 시간)
        //transform.position = transform.position + dir * speed * Time.deltaTime;

        transform.position += dir * speed * Time.deltaTime;
    }
}
