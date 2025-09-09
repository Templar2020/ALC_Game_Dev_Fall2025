using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the balloon up on the y axis at a set rate of speed
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
