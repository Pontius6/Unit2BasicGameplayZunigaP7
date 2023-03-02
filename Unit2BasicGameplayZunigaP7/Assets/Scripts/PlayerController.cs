using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float leftboundary = -10.0f;
    public float rightboundary = 10.0f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftboundary)
        {
            transform.position = new Vector3(leftboundary, transform.position.y, transform.position.z);
        }

        if (transform.position.x < rightboundary)
        {
            transform.position = new Vector3(rightboundary, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
