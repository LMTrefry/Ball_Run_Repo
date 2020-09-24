using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "Player")
        {
            Score.score += 10;
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.name == "Player")
        {
            Score.score += 10;
        }
    }
}
