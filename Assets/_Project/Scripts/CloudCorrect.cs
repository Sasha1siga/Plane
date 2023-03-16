using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteAlways]
public class CloudCorrect : MonoBehaviour
{
    private SpriteRenderer[] _cloudsRenderer;
    void Start()
    {
        _cloudsRenderer = GetComponentsInChildren<SpriteRenderer>();
        for (int i = 0; i < _cloudsRenderer.Length; i++)
        {
            _cloudsRenderer[i].sortingOrder = i;
        }
    }
}
