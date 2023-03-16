using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineSoundController : MonoBehaviour
{
    [SerializeField] AudioSource EngineSound;
  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") == 1 && !EngineSound.isPlaying)
        {
            EngineSound.Play();
        }
        else if (Input.GetAxis("Vertical") == 0 && EngineSound.isPlaying)
        
        {
            EngineSound.Pause();
        }
        
    }
}
