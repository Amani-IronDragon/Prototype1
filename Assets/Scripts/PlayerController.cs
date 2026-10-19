using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    

    public float turnSpeed = 20.0f;
    public float horizontalInput;
    public float forwardInput;

    //The car's speed
    public float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Commnad that the car move at the pace of seconds, so that how much time passes dictates how far the car has traveled.
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Moves the player forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}