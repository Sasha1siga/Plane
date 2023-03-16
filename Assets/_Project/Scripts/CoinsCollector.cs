using UnityEngine;
using UnityEngine.UI;


public class CoinsCollector : MonoBehaviour
{
    [SerializeField] Text CoinsCounterText;
    [SerializeField] int CoinsToWin;
    [SerializeField] private GameManager GameManager;
    private int Coins;
    private void Start()
    {
        ChangeCoinCounterText();
    }
    public void CollectCoin()
    {
        Coins += 1;
        ChangeCoinCounterText();
        if (Coins == CoinsToWin)
        {
            GameManager.GameOver();
        }
    }
    private void ChangeCoinCounterText()
    {
        CoinsCounterText.text = "Собрано " + Coins.ToString() + "/" + CoinsToWin;
    }
}