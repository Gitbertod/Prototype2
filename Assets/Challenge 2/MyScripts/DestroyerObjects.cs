using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerObjects : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {

        if (transform.position.y < -10) 
        {
            Debug.Log("GameOver");
            Destroy(gameObject);
        } 
        if (transform.position.x < -35) Destroy(gameObject);


    }
}
