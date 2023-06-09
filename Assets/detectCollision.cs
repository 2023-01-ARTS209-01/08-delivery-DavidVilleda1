using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollision : MonoBehaviour
{

    private bool hasPackage = false;


    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Color hasPackageColor;
    [SerializeField] Color doesNotHavePackageColor;

    private void Start()

    {


        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    private void OnCollisionEnter2D(Collision2D collision)

    {
        Debug.Log("We hit something!!! - " + collision.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D trigger)

    {

       // Debug.Log("We hit trigger!!! - " + trigger.gameObject.name);

        if(trigger.gameObject.CompareTag("Package") && !hasPackage)
        {

            Debug.Log(">>>>>picked up a package!");

            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
          Destroy(trigger.gameObject, 0.5f);


        }


        if (trigger.gameObject.CompareTag("Customer")&& hasPackage)
        {


            Debug.Log("<<<<<<delivered package!");
            spriteRenderer.color = doesNotHavePackageColor;

            hasPackage = false;
        }



    }





}
