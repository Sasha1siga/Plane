using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] float RotateSpeed = 100;
   

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, RotateSpeed * Time.deltaTime, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Health _health = collision.transform.root.GetComponent<Health>();
        if (_health)
        {
            _health.TakeDamage();
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
