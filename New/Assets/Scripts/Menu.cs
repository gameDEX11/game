using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
public class Menu : MonoBehaviour
{
    public GameObject player;
    //public GameObject uı;
    public GameObject pause;
    public playerMovement playerMovementScript;
    bool pauseEnded = true;

    public void PauseMenu()
    {
        pause.SetActive(true);
    }
    public void ReturnButton()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
        playerMovementScript.enabled = true;
        pauseEnded = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && (!pauseEnded) && SceneManager.GetActiveScene().buildIndex != 0)
        {
            Time.timeScale = 1;
            pause.SetActive(false);
            playerMovementScript.enabled = true;
            pauseEnded = true;
            
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && pauseEnded && SceneManager.GetActiveScene().buildIndex != 0)
        {
            Time.timeScale = 0;
            pause.SetActive(true);
            playerMovementScript.enabled = false;
            pauseEnded = false;
        }
    }
    private void OnLevelWasLoaded(int level)
    {
        player = GameObject.Find("Player");
    }

    public void startMenu()
    {
        SceneManager.LoadScene(00);
        //Destroy(uı);
        Destroy(player);
    }

    public void ExitToMenuButton()
    {
        Debug.Log("PlayerDeleted");
        Destroy(player);
        SceneManager.LoadScene(0);
    }
}
