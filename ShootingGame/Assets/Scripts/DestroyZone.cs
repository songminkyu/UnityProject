using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 부딪히는 녀석을 없애고 싶다.
public class DestroyZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // 그 물체를 없애고 싶다
        Destroy(other.gameObject);
    }
}
