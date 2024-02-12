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
    public int enemyHealth = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int level = 1; level <= playerLevel; level++)
        {
            playerStrength *= 1.25f;
            playerStrength = (int)playerStrength; // round down
        }
        // playerStrength = (int)(10 * (1 + (playerLevel - 1) * 0.25f));
        Debug.Log(playerStrength);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
