using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//목표 : 배경 스크롤이 되도록 하고싶다.
// 필요속성 : 머티리얼, 스크롤 속도
// 순서 : 
//  1. 살아 있는동안 계속 하고 싶다.
//  2. 방향이 필요하다
//  3. 스크롤 하고 싶다.
public class Background : MonoBehaviour
{
    // Start is called before the first frame update

    //속성
    public Material bgMaterial;
    public float scrollSpeed = 0.2f;

    private void Update()
    {
        Vector2 dir = Vector2.up;
        bgMaterial.mainTextureOffset += dir * scrollSpeed * Time.deltaTime;
    }
}
