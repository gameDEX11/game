using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
public class Restart : MonoBehaviour
{
    public GameObject player1;
    public void reStart()
    {
        SceneManager.LoadScene(1);
        Destroy(player1);
    }
   
}
