using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class Pausemenu : MonoBehaviour
{
    public static bool GameISpaused = false;
    public GameObject pausemenuui;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameISpaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pausemenuui.SetActive(false);
        Time.timeScale = 1f;
        GameISpaused = false;

    }
    void Pause()
    {
        pausemenuui.SetActive(true);
        Time.timeScale = 0f;
        GameISpaused = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu"); 
    }
    public void  Quitgame()
    {
        Application.Quit();
    }
}
