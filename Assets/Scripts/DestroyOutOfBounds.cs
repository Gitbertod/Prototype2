using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBound = 30;
    private float lowerBound = -40;
    void Start()
    {
        float topBound = 30;
    }

    
    void Update()
    {

        if(transform.position.z >= topBound) Destroy(gameObject);

        if (transform.position.z <= lowerBound) 
        {
            Debug.Log("GameOver");
            Destroy(gameObject);
        } 

        

    }
}
