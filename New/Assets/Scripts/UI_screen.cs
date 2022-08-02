using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class UI_screen : MonoBehaviour
{
    [SerializeField] playerMovement playerMovementScript;

    public void startGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        playerMovementScript.enabled = true;

    }
    public void pauseGame()
    {
        SceneManager.LoadScene(1);

    }
}
