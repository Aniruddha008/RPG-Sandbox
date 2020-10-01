using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolllowCamera : MonoBehaviour
{
    [SerializeField] Transform target; 

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position;
    }
}
