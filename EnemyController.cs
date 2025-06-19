using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public static int enemyCount;
    public GameObject winWindow;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyCount == 0)
        {
            winWindow.SetActive(true);
            Time.timeScale = 0;
        }
    }


}
