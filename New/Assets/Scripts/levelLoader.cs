using UnityEngine.SceneManagement;
using UnityEngine;

public class levelLoader : MonoBehaviour
{
   
    public bool isGameStarted;
    private bool mainLevel=true;
    public GameObject Player;
    public GameObject UI;
    public GameObject bar;
    
    void Start()
    { 
        DontDestroyOnLoad(Player);
        DontDestroyOnLoad(UI);
        
     
    }
    void Update()
    {
        
            
            
            if(SceneManager.GetActiveScene().buildIndex==0)
            {
                bar.SetActive(false);
                bar.SetActive(false);
                if(isGameStarted==true)
                {
                    Destroy(bar);
                }
            }
            else
            {
                bar.SetActive(true);
                isGameStarted=true;
            }
        if(Input.GetKeyDown(KeyCode.N)&&mainLevel)
        {
           
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            mainLevel=false;
            
        }
        else if(Input.GetKeyDown(KeyCode.N)&&(!mainLevel))
        {
            if(Player.transform.position.x>9.6f||Player.transform.position.x<8.3f)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
                mainLevel=true;
            }

        }
        
    }
}
