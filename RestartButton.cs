using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void Restart()
    {
        
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}
