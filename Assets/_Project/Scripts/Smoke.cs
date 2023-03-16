using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour
{
    [SerializeField] ParticleSystem SmokeFromMotor;
    
    public void Controller()
    {
        if (Input.GetAxis("Vertical") == 1 && !SmokeFromMotor.isPlaying)
        {
            SmokeFromMotor.Play();
        }
        else if(Input.GetAxis("Vertical") == 0 && SmokeFromMotor.isPlaying)
        {
            SmokeFromMotor.Stop();
        }
    }
}
