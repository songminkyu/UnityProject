using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//사용자가 발사버튼을 누르면 총알을 발사하개 만든다.
//필요 속성 : 총알공장, 총구
public class PlayerFire : MonoBehaviour
{
    //총알을 생산할 공장
    public GameObject bulletFactory;

    //총구
    public GameObject firePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //1. 총알을 발사하고 싶다.
        // -> 만약 사용자가 발사버튼을 누르면
        if(Input.GetButtonDown("Fire1"))
        {
            //2. 총알공장에서 총알을 만든다.
            GameObject bullet = Instantiate(bulletFactory);
            //3. 사용자가 발사버튼을 눌럿으니까!!
            bullet.transform.position = firePosition.transform.position;
        }


    }
}
