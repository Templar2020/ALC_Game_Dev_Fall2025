using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float speed = 30.0f;
    public int timeOut = 5;
    


    // Start is called before the first frame update
    void Start()
    {
       Destroy(gameObject, timeOut); // Destroy this gameobject after timeOut has run down to zero 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime); // Makes the gameObject move forward at a set rate of speed
    }
}
