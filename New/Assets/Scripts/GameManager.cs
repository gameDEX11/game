using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
public class GameManager : MonoBehaviour
{
    public GameObject Bar;
    public GameObject pause;
    public playerStamina staminaPlayer;
    
    public playerMovement player;
    bool pauseEnded=true;
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Escape)&&(!pauseEnded)&&SceneManager.GetActiveScene().buildIndex!=0)
        {
            Time.timeScale=1;
            pause.SetActive(false);
            player.enabled=true;
            pauseEnded=true;
            staminaPlayer.enabled=true;
            Bar.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.Escape)&&pauseEnded&&SceneManager.GetActiveScene().buildIndex!=0)
        {
            pause = GameObject.Find("PauseMenu");
            Time.timeScale=0;
            pause.SetActive(true);
            player.enabled=false;
            pauseEnded=false;
            staminaPlayer.enabled=false;
            Bar.SetActive(false);
        }
       
    }

}
