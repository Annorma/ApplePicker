using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    static public int score = 0;
    void Awake()
    { // 1
      // If the ApplePickerHighScore already exists, read it
        if (PlayerPrefs.HasKey("ApplePickerHighScore"))
        { // 2
            score = PlayerPrefs.GetInt("ApplePickerHighScore");
        }
        // Assign the high score to ApplePickerHighScore
        PlayerPrefs.SetInt("ApplePickerHighScore", score); // 3
    }

    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "Best score: " + score;
        if (score > PlayerPrefs.GetInt("ApplePickerHighScore"))
        { // 4
            PlayerPrefs.SetInt("ApplePickerHighScore", score);
        }
    }
    
}
