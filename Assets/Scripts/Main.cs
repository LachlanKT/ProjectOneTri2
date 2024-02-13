using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
   public float playerStrength = 10;
    public int playerLevel = 1;
    public int playerExp = 0;
    public int playerExpThreshold = 0;
    public int enemyLevel = 0;
    public float enemyHealth = 10;
    

    // Start is called before the first frame update
    void Start()
    {
        for (int level = 2; level <= playerLevel; level++)
        {
            playerStrength *= 1.25f;
            playerStrength = (int)playerStrength; // round down
        }
        // playerStrength = (int)(10 * (1 + (playerLevel - 1) * 0.25f));
        Debug.Log("Players strength equals: " + playerStrength);

        EnemyAppears();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        
        {
            EnemyBattle();
        }
    }

    public void EnemyAppears() 
    {
        enemyLevel = Random.Range(1, 11);
        Debug.Log("Enemy level equals: " + enemyLevel);

        for (int checkEnemyLevel = 2; checkEnemyLevel <= enemyLevel; checkEnemyLevel++)
        {
            enemyHealth *= 1.25f;
            enemyHealth = (int)enemyHealth; // round down
        }
        Debug.Log("EnemyHealth equals: " + enemyHealth);
    }
    public void EnemyBattle() 
    {
        enemyHealth = enemyHealth - playerStrength;
        Debug.Log("Enemy health equals: " + enemyHealth);
    }
}
