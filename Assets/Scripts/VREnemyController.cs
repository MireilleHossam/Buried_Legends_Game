using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VREnemyController : MonoBehaviour
{
    public Transform player;
    public Animator enemy;

    public float distanceThreshold = 3f;
    public float attackingSpeed = 5f;
    public float walkingSpeed = 2f;
    public float deathSpeed = 2f;

    void Update()
    {
        // Calculate the distance between the player and the VR character
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Determine movement and animation based on the distance
        if (distanceToPlayer > distanceThreshold)
        {
            // Far from the player, play walking animation and move slowly
            enemy.SetBool("isWalking", true);
            enemy.SetBool("isAttacking", false);
            enemy.SetBool("isDieing", false);
            MoveCharacter(walkingSpeed);
        }
        else if (distanceToPlayer <= distanceThreshold && distanceToPlayer > 1.0f)
        {
            // Close to the player, play attacking animation and move quickly
            enemy.SetBool("isWalking", false);
            enemy.SetBool("isAttacking", true);
            enemy.SetBool("isDieing", false);
            MoveCharacter(attackingSpeed);
        }
        else
        {
            // Close to the player, play dying animation and move quickly
            enemy.SetBool("isWalking", false);
            enemy.SetBool("isAttacking", false);
            enemy.SetBool("isDieing", true);
            MoveCharacter(deathSpeed);
        }
    }

    void MoveCharacter(float speed)
    {
        // Move the VR character forward in the direction of the player
        Vector3 direction = player.position - transform.position;
        direction.y = 0; // Keep the character level
        direction.Normalize();
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}


