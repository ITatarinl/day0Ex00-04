using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex01Script : MonoBehaviour
{
    public GameObject cube;
    private float spawnWait = 1f;
    private float spawnAdvance = 0.005f;

    void Start()
    {
    }

    void Update()
    {
        spawnWait -= spawnAdvance;
        if (spawnWait < 0) 
        {
            spawnWait = 1.0f;
            //spawnCount++;
            switch (Random.Range(0, 3))
            {
                case 0:
                    Instantiate(cube, new Vector3(-5.8f, 5.5f, 0), Quaternion.identity);
                    break;
                case 1:
                    Instantiate(cube, new Vector3(0, 5.5f, 0), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(cube, new Vector3(6.1f, 5.5f, 0), Quaternion.identity);
                    break;
            } 
        }
    }
}
