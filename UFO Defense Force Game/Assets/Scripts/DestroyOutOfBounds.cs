using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 50.0f, lowerBounds = -30.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if(transform.position.z > topBounds){
                Destroy(gameObject);
            }

            else if(transform.position.z < lowerBounds){
                Destroy(gameObject);
            }

            else if(transform.position.y > topBounds){
                Destroy(gameObject);
            }

            else if(transform.position.y < lowerBounds){
                Destroy(gameObject);
            }
    }
}
