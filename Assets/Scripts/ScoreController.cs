using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;
    public Text coinText;
    // Start is called before the first frame update
    private int Score = 0;
    private int coins = 0;

    void Start()
    {
        scoreText.text = "Puntaje: " + Score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int GetScore()
    {
        return this.Score;
    }

    public void PlusScore(int score)
    {
        this.Score += score;
        scoreText.text = "Puntaje: " + Score;
    }

    public void gainBronzeCoin()
    {
        coins += 10;
    }

    public void getCoins(int Coins)
    {
        this.coins += Coins;
        coinText.text = "Monedas: " + coins;
    }
}
