using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{

    [SerializeField] Dialogue dialogueManager;

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.CompareTag("Player") && Input.GetKey(KeyCode.F))
        {

            Debug.Log("Dialogue is available");
            dialogueManager.enabled = true;

        }
    }
}
