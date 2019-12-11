using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{
    public KeyCode resetScene, resetGame, quitGame, nextScene;
    public bool enableNext;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (enableNext == true)
        {
            NextScene();
        }
    }

    void ResetScene()
    {
        if (Input.GetKeyDown(resetScene))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void ResetGame()
    {
        if (Input.GetKeyDown(resetGame))
        {
            SceneManager.LoadScene(0);
        }
    }

    void QuitGame()
    {
        if (Input.GetKeyDown(quitGame))
        {
            Application.Quit();
        }
    }

    void NextScene()
    {
        if (Input.GetKeyDown(nextScene))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
