using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private PlayerController player;
    public static int coinCount;
    public Text coinText;
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        coinText.text = "Score: " + coinCount;
    }

    public void AddCoins(int coinsToAdd)
    {
        coinCount = coinCount + coinsToAdd;
        coinText.text = "Score: " + coinCount;
    }
}
