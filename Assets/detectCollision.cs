using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollision : MonoBehaviour
{



    private void OnCollisionEnter2D(Collision2D collision)

    {
        Debug.Log("We hit something!!! - " + collision.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D trigger)

    {

        Debug.Log("We hit trigger!!! - " + trigger.gameObject.name);


    }





}
