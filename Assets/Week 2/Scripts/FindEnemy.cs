using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemy : MonoBehaviour
{
    public List<Enemy> enemies;
    //----------------------Edit below here --------------------
    public Enemy FindEnemyWithSmallestHealth()
    {
        Enemy enemySmallestHealth = enemies[0];
        foreach (Enemy enemy in enemies)
        {
            if (enemy.Health < enemySmallestHealth.Health)
            {
                enemySmallestHealth = enemy;
            }
        }
        return enemySmallestHealth;
    }

    public Enemy FindEnemyWithLargestHealth()
    {
        Enemy enemyLargestHealth = enemies[0];
        foreach (Enemy enemy in enemies)
        {
            if (enemy.Health > enemyLargestHealth.Health)
            {
                enemyLargestHealth = enemy;
            }
        }
        return enemyLargestHealth;
    }

    //----------------------Edit above here --------------------
}
