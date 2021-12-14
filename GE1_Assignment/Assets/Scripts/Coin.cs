using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float turnSpeed = 90f;
    void onTriggerEnter(Collider other)
    {
        //Check that the object we collided with is the player
        if(other.gameObject.name != "Player")
        {
            return;
        }

        Destroy(gameObject);
    }
 
    private void Update()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }
}
