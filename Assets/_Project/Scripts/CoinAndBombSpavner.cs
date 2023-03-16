using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAndBombSpavner : MonoBehaviour
{
    [SerializeField] GameObject _coinPrefab;
    [SerializeField] GameObject _bombPrefab;
    [SerializeField] int _coinAmount = 15;
    [SerializeField] int _bombAmount = 7;
    [SerializeField] Transform _coinParent;
    [SerializeField] Transform _bonbParent;
    [SerializeField] Transform _cornerA;
    [SerializeField] Transform _cornerB;
    void Start()
    {
        
        Create(_coinPrefab, _coinAmount, _coinParent);
        Create(_bombPrefab, _bombAmount, _bonbParent);
    }
    void Create(GameObject CreateObject, int amount, Transform parent)
    {
        for (int i = 0; i < amount; i++)
        {
            float X = Random.Range(_cornerA.position.x, _cornerB.position.x);
            float Y = Random.Range(_cornerA.position.y, _cornerB.position.y);
            GameObject create = Instantiate(CreateObject, new Vector3(X, Y, 0), CreateObject.transform.rotation, parent);
        }
    }
    private void OnDrawGizmos()
    {
        Vector3 center = (_cornerB.position + _cornerA.position) / 2;
        Vector3 size = _cornerB.position - _cornerA.position;
        Gizmos.DrawWireCube(center, size);
    }
}
