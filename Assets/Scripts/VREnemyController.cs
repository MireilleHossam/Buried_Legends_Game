using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VREnemyController : MonoBehaviour
{
    public Transform player;
    public Animator enemy;

    public float distanceThreshold = 0.5f;
    public float attackingSpeed = 2f;
    public float walkingSpeed = 2f;
    public float deathSpeed = 2f;
    public float idleSpeed = 2f;

    private bool isDead = false;

    private void Start()
    {
        //enemy.SetBool("IsIdle", true);
    }

    void Update()
    {
        if (!isDead)
        {
            Vector3 playerPosition = new Vector3(player.position.x, 0f, player.position.z);
            Vector3 modifierdTransform = new Vector3(transform.position.x, 0f, transform.position.z);
            // Calculate the distance between the player and the VR character
            float distanceToPlayer = Vector3.Distance(modifierdTransform, playerPosition);

            // Determine movement and animation based on the distance
            if (distanceToPlayer > distanceThreshold)
            {
                // Far from the player, play walking animation and move slowly
                SetMovementParameters(false, true, false, walkingSpeed);
            }
            else if (distanceToPlayer <= distanceThreshold )
            {
                // Close to the player, play attacking animation and move quickly
                SetMovementParameters(false, false, true, attackingSpeed);
            }
            else
            {
                // Close to the player, play dying animation and move quickly
                SetMovementParameters(false, false, false, deathSpeed);
            }
        }
    }
    //&& distanceToPlayer > 1.0f LINE 36
    void SetMovementParameters(bool isIdle, bool isWalk, bool isAttack, float speed)
    {
        // Set animation parameters
        enemy.SetBool("IsIdle", isIdle);
        enemy.SetBool("IsWalk", isWalk);
        enemy.SetBool("IsAttack", isAttack);

        // Move the VR character forward in the direction of the player
        if (isWalk)
        {
            Vector3 direction = player.position - transform.position;
        direction.y = 0; // Keep the character level
        direction.Normalize();
        
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
        }
    }

    // Add this method to handle collisions
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has a specific tag (customize as needed)
        if (collision.gameObject.CompareTag("Sword"))
        {
            // Trigger death animation or perform other actions
            PerformDeath();
        }
    }

    private void PerformDeath()
    {
        // Implement your death animation or other actions here
        // For example, you might play an animation, disable enemy controls, etc.
        isDead = true;
        enemy.SetTrigger("IsDeath");
        Debug.Log("Enemy collided with death zone. Triggering death animation.");
    }
}
