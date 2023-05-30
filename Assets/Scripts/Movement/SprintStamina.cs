using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprintStamina : MonoBehaviour
{
    public float sprintSpeed = 10f; // Speed at which the player sprints
    public float walkSpeed = 5f; // Speed at which the player walks
    public float staminaMax = 100f; // Maximum stamina value
    public float staminaCost = 10f; // Stamina cost per second while sprinting
    public float staminaRecoveryRate = 5f; // Stamina recovery rate per second

    private float currentStamina; // Current stamina value
    private bool isSprinting = false; // Flag indicating if the player is sprinting

    // Start is called before the first frame update
    void Start()
    {
        currentStamina = staminaMax; // Set the initial stamina to maximum
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player is sprinting
        if (Input.GetKey(KeyCode.LeftShift) && currentStamina > 0)
        {
            isSprinting = true;
            currentStamina -= staminaCost * Time.deltaTime; // Deduct stamina based on the sprint cost per second
            currentStamina = Mathf.Max(currentStamina, 0f); // Ensure stamina doesn't go below zero
        }
        else
        {
            isSprinting = false;
            currentStamina += staminaRecoveryRate * Time.deltaTime; // Recover stamina based on the recovery rate per second
            currentStamina = Mathf.Min(currentStamina, staminaMax); // Ensure stamina doesn't exceed maximum value
        }

        // Set the player's movement speed based on sprinting state
        float currentSpeed = isSprinting ? sprintSpeed : walkSpeed;
        // Apply the movement speed to the player's movement

        // Your movement code goes here...
        // For example:
        // transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
    }
}
