using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restart()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void backMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void toOptions()
    {
        SceneManager.LoadScene("OptionsMenu");
    }
}
