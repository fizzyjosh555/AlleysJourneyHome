using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Sprite[] HeartSprites;
    public Image HeartUI;
    private PlayerController player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if(PlayerController.curHealth < 0) { PlayerController.curHealth = 0; }
        {
            HeartUI.sprite = HeartSprites[PlayerController.curHealth];
        }
    }
}
