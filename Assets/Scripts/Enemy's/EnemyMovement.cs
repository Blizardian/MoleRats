using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed at which the enemy moves
    private Transform target; // Reference to the player's transform

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform; // Find the player's transform
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player's transform is found
        if (target != null)
        {
            // Calculate the direction from the enemy to the player
            Vector3 direction = target.position - transform.position;
            direction.Normalize(); // Normalize the direction vector to have a magnitude of 1

            // Move the enemy towards the player
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
    }
}