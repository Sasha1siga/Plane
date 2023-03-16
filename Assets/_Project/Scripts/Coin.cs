using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] float RotateSpeed = 40;

    void Update()
    {
        transform.Rotate(0, 0, RotateSpeed * Time.deltaTime);
    }

    void Die()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("hi");
        CoinsCollector coinsCollector = other.transform.root.GetComponent<CoinsCollector>();
        if (coinsCollector)
        {
            coinsCollector.CollectCoin();
            Die();
        }
    }
}
