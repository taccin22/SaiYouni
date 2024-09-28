using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // 5 Enemies variables

    public float health;
    public float damage;
    public float moveSpeed;
    public Transform target;
    public bool isAlive;

    public float aggroRange = 2.0f;


    // 5 Enemies methods

    //Method 1
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    //Method 2
    public void MoveTowardsTarget()
    {
        if (isAlive)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        }
    }

    //Method 3
    private void MoveRandomly()
    {
        float randomX = Random.Range(-1f, 1f);
        float randomZ = Random.Range(-1f, 1f);
        Vector3 randomDirection = new Vector3(randomX, 0, randomZ).normalized;

        transform.position += randomDirection * moveSpeed * Time.deltaTime;
    }

    //Method 4
    public void Die()
    {
        isAlive = false;
        Destroy(gameObject);
    }

    //Method 5
    public void CheckAggro()
    {
        float distanceToTarget = Vector3.Distance(transform.position, target.position);

        if (isAlive)
        {
            if (distanceToTarget < aggroRange)
            {
                MoveTowardsTarget();
            }
            else
            {
                MoveRandomly();
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
