using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
   
private void OnCollisionEnter2D(Collision2D collision)
{

Debug.Log("We hit Something!!" + collision.gameObject.name);


}



private void OnTriggerEnter2D(Collider2D trigger)
{

Debug.Log("We hit Something!!  -  " + trigger.gameObject.name);
}

}