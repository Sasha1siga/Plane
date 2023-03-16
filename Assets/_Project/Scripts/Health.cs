using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private int MaxHealth;
    [SerializeField] Text StepToDie;
    [SerializeField] GameManager _gameManager;
    private int _currentHealth;
    void Start()
    {
        _currentHealth = MaxHealth;
        StepToDie.text = "�� ������" + _currentHealth  + "/" + MaxHealth;
    }
    public void TakeDamage()
    {
        _currentHealth--;
        StepToDie.text = "�� ������" + _currentHealth + "/" + MaxHealth;
        if (_currentHealth == 0)
        {
            _gameManager.GameOver();
        }
    }
}
