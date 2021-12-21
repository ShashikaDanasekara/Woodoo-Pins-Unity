using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject pinPrefab;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown(KeyWords.jump))
        {
            SpawnPin();
        }
    }

    void SpawnPin()
    {
        Instantiate(pinPrefab,transform.position,transform.rotation);
    }
}
