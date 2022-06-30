using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogSpawner : MonoBehaviour
{
    public GameObject dog;
    private bool spawn = false;
    public float time = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && spawn == false) 
        {
            Instantiate(dog, dog.transform.position, dog.transform.rotation);
            
            spawn = true;
        
        }
        if (spawn) 
        {
            time += Time.deltaTime;
            if (time > 2) 
            {
                time = 0;
                spawn = !spawn;
            } 
            
        }


    }
}
