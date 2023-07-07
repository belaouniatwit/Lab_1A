using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int playerScore = 0;
    public int npcScore = 0;

    void OnGUI()
    {
        GUIStyle scoreStyle = new GUIStyle();
        scoreStyle.fontSize = 24;
        scoreStyle.normal.textColor = Color.white;

        GUI.Label(new Rect(10, 10, 200, 50), "Player Score: " + playerScore, scoreStyle);
        GUI.Label(new Rect(10, 60, 200, 50), "NPC Score: " + npcScore, scoreStyle);
    }

    public void UpdatePlayerScore()
    {
        playerScore++;
    }

    public void UpdateNPCScore()
    {
        npcScore--;
    }
}
