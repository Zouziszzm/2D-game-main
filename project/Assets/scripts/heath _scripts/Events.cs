using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Events : MonoBehaviour
{
    public void Replaylevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void gamemenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
