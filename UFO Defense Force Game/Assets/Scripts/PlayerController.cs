using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float hInput, speed; 
    private float xRange = 25f;
    public GameObject laser;
    public Transform blaster;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // recieve values from keyboard through horizontal input in unity
        hInput = Input.GetAxis("Horizontal");

        // Player movement
        transform.Translate(Vector3.right * hInput * speed * Time.deltaTime);

        // Keep player in bounds
        if(transform.position.x > xRange){
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.x < -xRange){
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(laser, blaster.transform.position, laser.transform.rotation); // spawn laser at blaster position
        }
    }
}
