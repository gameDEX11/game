using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public GameObject dialogueGroup;
    public TextMeshProUGUI displayText;
    public string[] sentences;
    public playerMovement movement;

    int index;

    public GameObject continueButton;

    [SerializeField]
    float typingSpeed = 0.02f;

    [SerializeField] float timeOut = 5f;
    float estTime = 0f;

     void Start()
    {
        movement=FindObjectOfType<playerMovement>();
        Debug.Log("Dialogue");
        dialogueGroup.SetActive(true);
        StartCoroutine(Type());
        movement.enabled=false;
    }

    private void Update()
    {
        estTime += Time.time;
    }



    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            displayText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextLine()
    {
        continueButton.SetActive(false);
        if(estTime>timeOut)
        {
            displayText.text = sentences[index];
            estTime = 0f;
        }


        if (index < sentences.Length)
        {
            if(displayText.text == sentences[sentences.Length-1])
            {
                dialogueGroup.SetActive(false);
                movement.enabled = true;
                
            }
            index++;
            displayText.text = "";
            StartCoroutine(Type());
            continueButton.SetActive(true);

        }
        else
        {
            
            displayText.text = "";
            
        }
    }

}
