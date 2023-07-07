using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeSinceLastSpawn;
    private float spawnCoolDown = 1.0f;

    // Update is called once per frame
    void Update()
    {
        //Increment the timer since the last spawn
        timeSinceLastSpawn += Time.deltaTime;

        // On spacebar press and time since last spawn longer than spawn cool down, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timeSinceLastSpawn >= spawnCoolDown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            //Reset the timer
            timeSinceLastSpawn = 0f;

            
        }
    }
}
