using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float time = 0;
    private bool tStart = false;
    // Update is called once per frame
    void Update()
    {


        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && tStart == false)
        {
            SpawnDog();
            tStart = true;

        }
        if (tStart)
        {
            time += Time.deltaTime;
            if(time > 2) 
            {
                time = 0;
                tStart = !tStart;
            }
        }
    }

    void SpawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}

