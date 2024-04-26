using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuCotrols : MonoBehaviour
{
    void Start()
    {
        
    }

    public void LoadPreview()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
