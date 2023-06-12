using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTriggerRadius : MonoBehaviour
{
    public float triggerRadius = 10f;
    public LayerMask playerLayer;

    private bool playerInRange = false;

    private void Update()
    {
        if (playerInRange)
        {
            // Do something when the player is within the trigger radius
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (IsPlayerInLayerMask(other.gameObject.layer))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (IsPlayerInLayerMask(other.gameObject.layer))
        {
            playerInRange = false;
        }
    }

    private bool IsPlayerInLayerMask(int layer)
    {
        return (playerLayer.value & (1 << layer)) != 0;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, triggerRadius);
    }
}
