using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseManager : MonoBehaviour
{
    [SerializeField] public int playerBaseHealth = 50;
    [SerializeField] public int enemyBaseHealth = 100;

    [SerializeField] public float reasource = 10;
    [SerializeField] public float reasourceRate;

    //Counts how many loops of fixed update happened
    private int fixedUpdateCounter = 0;
    private void Update()
    {
        if (playerBaseHealth <= 0)
        {
            Debug.Log("***Implement Game Over Here***");
        } 

        if (enemyBaseHealth <= 0)
        {
            Debug.Log("***Implement Win Here***");
        }
    }

    private void FixedUpdate()
    {
        if (fixedUpdateCounter == 60)
        {
            reasource += reasourceRate;
            fixedUpdateCounter = 0;
        }
        else
        {
            fixedUpdateCounter++;
        }

    }
}