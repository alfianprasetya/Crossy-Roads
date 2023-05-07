using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleSpawner : MonoBehaviour
{
    [SerializeField] Eagle eagle;
    [SerializeField] Ducks ducks;
    [SerializeField] float initialTimer;

    float timer;
    
    void Start()
    {
        timer = initialTimer; 
        eagle.gameObject.SetActive(false);   
    }

    void Update()
    {
        if(timer <= 0 && eagle.gameObject.activeInHierarchy == false)
        {
            eagle.gameObject.SetActive(true);
            eagle.transform.position = ducks.transform.position + new Vector3(0,0,13);     
            ducks.SetMoveable(false);  
        }
        timer -= Time.deltaTime; 
    }

    public void ResetTimer()
    {
        timer = initialTimer;
    }
}
