using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotation : MonoBehaviour
{
    public Transform player; // Reference to the player's transform

    // Update is called once per frame
    void Update()
    {
        // Calculate the direction towards the player
        Vector3 direction = player.position - transform.position;
        direction.y = 0f; // Ignore vertical difference

        // Rotate the enemy towards the player
        transform.rotation = Quaternion.LookRotation(direction);
    }
}