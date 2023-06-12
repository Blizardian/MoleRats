using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFollowPlayer : MonoBehaviour
{
    public Transform player;
    public float followSpeed = 5f;

    private bool isFollowing = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isFollowing = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isFollowing = false;
        }
    }

    private void Update()
    {
        if (isFollowing)
        {
            Vector3 targetPosition = new Vector3(player.position.x, transform.position.y, player.position.z);
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, followSpeed * Time.deltaTime);
        }
    }
}