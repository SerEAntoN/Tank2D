using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void OnClicked()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

}
