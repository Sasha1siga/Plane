using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPlane : MonoBehaviour
{
    [SerializeField] private float MoveSpeed;
    [SerializeField] private float RotationSpeed;
    [SerializeField] Smoke SmokeSkript;
    private Rigidbody _planeRigidbody;
    private void Start()
    {
        _planeRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Fly();
        SmokeSkript.Controller();
    }
    private void Fly()
    {
        if (Input.GetAxis("Vertical") >= 0)
        {
            _planeRigidbody.AddRelativeForce(Input.GetAxis("Vertical") * MoveSpeed, 0, 0);
        }
        _planeRigidbody.AddTorque(0, 0, -Input.GetAxis("Horizontal") * RotationSpeed);
    }
}
