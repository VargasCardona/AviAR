using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DemoController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GoBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
