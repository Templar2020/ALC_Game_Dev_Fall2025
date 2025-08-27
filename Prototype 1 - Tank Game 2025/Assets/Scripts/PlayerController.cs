using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 30.0f;
    public float turnSpeed = 50.0f;
    public GameObject projectile; // reference the projectile prefab
    public Transform firePoint; // the point at which the projectile is going to instatiate

    // Update is called once per frame
    void Update()
    {
        // This code gathers the inputs/keybindings from the keyboard
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical"); 

        //This code makes the tank move forward and back
        transform.Translate(Vector3.forward * vInput * moveSpeed * Time.deltaTime);
        //This code makes the tank rotate left and right
        transform.Rotate(Vector3.up, hInput * turnSpeed * Time.deltaTime);
        // This code instantiate a projectile object
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, firePoint.position, firePoint.rotation);
        }

    }
}
