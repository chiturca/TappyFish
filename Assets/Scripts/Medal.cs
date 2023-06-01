using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Medal : MonoBehaviour
{
    public Sprite metalMedal, bronzeMedal, silverMedal, goldMedal;
    Image img;
    
    void Start()
    {
        img = GetComponent<Image>();
    }

    
    void Update()
    {
        int gameScore = GameManager.gameScore;

        if (gameScore > 0 && gameScore <= 10)
        {
            img.sprite = metalMedal;
        }else if (gameScore > 10 && gameScore <= 20)
        {
            img.sprite = bronzeMedal;
        }else if (gameScore > 20 && gameScore <= 30)
        {
            img.sprite = silverMedal;
        }else if (gameScore > 30)
        {
            img.sprite = goldMedal;
        }
    }
}
