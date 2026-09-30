using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    //The car's speed
    public float speed = 35;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Commnad that the car move at the pace of seconds, so that how much time passes dictates how far the car has traveled.
        transform.Translate(Vector3.forward * Time.deltaTime * 35);
    }
}