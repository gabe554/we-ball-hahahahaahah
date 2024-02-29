using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logicScript : MonoBehaviour
{
    public static int playerScore = 0;
    public Text scoreText;

    [ContextMenu("add point")]

    private void Start()
    {
        
        scoreText = GetComponent<Text>();
        scoreText.text = "0";
    }
    private void Update()
    {

        scoreText.text = playerScore.ToString();
    }
}
