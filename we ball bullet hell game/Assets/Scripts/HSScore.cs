using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HSScore : MonoBehaviour
{
    public Text HScoreText;
    public static int HScore = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        HScoreText = GetComponent<Text>();
    }
    
    // Update is called once per frame
    void Update()
    {
        HScoreText.text = HScore.ToString();
    }
}
