using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed at which the player moves
    public float sprintSpeedMultiplier = 1.5f; // Multiplier for sprinting speed
    public float jumpForce = 5f; // Force applied when the player jumps
    public float staminaMax = 100f; // Maximum stamina value
    public float sprintStaminaCost = 10f; // Stamina cost per second while sprinting
    public float staminaRecoveryRate = 5f; // Stamina recovery rate per second

    private bool isSprinting = false; // Flag indicating if the player is sprinting
    private bool isJumping = false; // Flag indicating if the player is jumping
    private float currentStamina; // Current stamina value
    private Rigidbody rigidbody; // Reference to the Rigidbody component

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>(); // Get the Rigidbody component
        currentStamina = staminaMax; // Set the initial stamina to maximum
    }

    // Update is called once per frame
    void Update()
    {
        // Get raw horizontal and vertical input values without input delay
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Normalize the movement direction
        Vector3 movementDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Calculate the desired movement amount based on the speed and time
        float movementAmount = moveSpeed;

        // Check if the player is sprinting
        if (Input.GetKey(KeyCode.LeftShift) && currentStamina > 0)
        {
            isSprinting = true;
            movementAmount *= sprintSpeedMultiplier; // Apply sprinting speed multiplier
            currentStamina -= sprintStaminaCost * Time.deltaTime; // Deduct stamina based on the sprint cost per second
            currentStamina = Mathf.Max(currentStamina, 0f); // Ensure stamina doesn't go below zero
        }
        else
        {
            isSprinting = false;
            currentStamina += staminaRecoveryRate * Time.deltaTime; // Recover stamina based on the recovery rate per second
            currentStamina = Mathf.Min(currentStamina, staminaMax); // Ensure stamina doesn't exceed maximum value
        }

        // Apply the movement to the player's position
        transform.Translate(movementDirection * movementAmount * Time.deltaTime);

        // Check if the player wants to jump
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            isJumping = true;
            rigidbody.AddForce(new Vector3(0f, jumpForce, 0f), ForceMode.Impulse);
        }
    }

    // OnCollisionEnter is called when the player collides with another object
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the player has landed on the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}
