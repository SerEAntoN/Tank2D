using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform shootPoint;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time ++;
        if(time == 720)
        {
            Instantiate(bullet, shootPoint.transform.position, transform.rotation);
            time = 0;
            GetComponent<AudioSource>().Play();
        }
    }
}
