using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class enemyCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject endScreen;

    public void Start()
    {
        endScreen.SetActive(false);
    }
    public void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMovement>().enabled = false;
        endScreen.SetActive(true);
        Time.timeScale = 0;
    }
}
