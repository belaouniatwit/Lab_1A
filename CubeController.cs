using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private GameController scoreManager;

    void Start()
    {
        scoreManager = GameObject.Find("GameController").GetComponent<GameController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Call the method in GameController to update the player's score
            scoreManager.UpdatePlayerScore();
            // Destroy the cube
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
    }
}


