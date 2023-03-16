using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteAlways]
public class CametaFollow : MonoBehaviour
{
    [SerializeField] private Transform PlayerTransform;

    

    void Update()
    {
        transform.position = new Vector3(PlayerTransform.position.x, PlayerTransform.position.y, PlayerTransform.position.z);
    }
}
