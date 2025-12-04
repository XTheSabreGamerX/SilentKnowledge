using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyGameManager : MonoBehaviour
{
    public static MyGameManager Instance;

    public TextMeshProUGUI objectiveText;
    public TextMeshProUGUI messageText;

    public AudioSource winAudio;
    public AudioSource loseAudio;

    void Awake()
    {
        Instance = this;
        messageText.text = "";
        objectiveText.text = "Objective: Find the missing phone";
    }

    public void WinGame()
    {
        winAudio.Play();
        messageText.text = "You found the phone! You win!";
        Time.timeScale = 0f;
    }

    public void LoseGame()
    {
        loseAudio.Play();
        messageText.text = "You didn't find the phone on time...";
        Time.timeScale = 0f;
    }
}
