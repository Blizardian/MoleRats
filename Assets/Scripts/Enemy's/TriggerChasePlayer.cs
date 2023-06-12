using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChasePlayer : MonoBehaviour
{
    public Transform player;
    public float chaseSpeed = 5f;

    private bool isChasing = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isChasing = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isChasing = false;
        }
    }

    private void Update()
    {
        if (isChasing)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * chaseSpeed * Time.deltaTime;
        }
    }
}