using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{


    public float speed = 40;
    
    void Start()
    {
        
    }

   
    void Update()
    {

        transform.Translate(Vector3.forward * speed * Time.deltaTime);


    }
}
