using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnrate = 5f;
    public GameObject hexagonPrefab;
    private float nextTimeToSpawn=0f;
    public static int score = 0;
    public static int tot_score;
    // Update is called once per frame
    void Update()
    {

        
        if(Time.time >= nextTimeToSpawn)
        {
            score = score +10;
            
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f/spawnrate;
            Debug.Log(score);
          
        }
        tot_score = score;

    }
}
