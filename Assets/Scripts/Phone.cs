using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    public MyGameManager gameManager;

    void OnMouseDown()
    {
        if (gameManager != null)
        {
            gameManager.WinGame();
        }
    }
}