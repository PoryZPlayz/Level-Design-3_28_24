using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the speed as needed
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Get input for movement
        float moveHorizontal = Input.GetAxis("Horizontal"); // Horizontal axis for left and right movement
        float moveVertical = Input.GetAxis("Vertical"); // Vertical axis for forward and backward movement

        // Calculate movement direction based on input
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical).normalized;

        // Move the player
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        // Set animation parameter based on movement
        animator.SetBool("isRunning", movement.magnitude > 0f);
    }
}
