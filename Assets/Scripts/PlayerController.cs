using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float xRange;
    public float speed = 10f;
    public GameObject pizzaPrefab;

    void Start()
    {
        xRange = 12;
    }

    
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontal * Time.deltaTime * speed);

        if (transform.position.x <= -xRange) 
        {

            transform.position = new Vector3(-xRange,transform.position.y);
        }
        if (transform.position.x >= xRange)
        {

            transform.position = new Vector3(12, transform.position.y);
        }

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(pizzaPrefab,transform.position,transform.rotation);
        
        }

    }
}
