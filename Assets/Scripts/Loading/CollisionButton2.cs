using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionButton2 : MonoBehaviour
{
    public UnityEvent onClick;

    private bool isColliding = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isColliding = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isColliding = false;
        }
    }

    private void Update()
    {
        if (isColliding && Input.GetKeyDown(KeyCode.E))
        {
            onClick.Invoke();
        }
    }
}