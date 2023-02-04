using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonSpawner : MonoBehaviour
{
    [SerializeField] int resourceCost = 1;

    [SerializeField] private int spawnNodeNum;
    [SerializeField] private int endNodeNum;

    [SerializeField] private BaseSprite enemyType;

    [SerializeField] int spawnHealth = 1;
    [SerializeField] int spawnDamage = 1;

    [SerializeField] float movementSpeed = 0.4f;

    BaseManager baseManager;

    private void Start()
    {
        baseManager = GameObject.FindAnyObjectByType<BaseManager>();
    }
    private void OnMouseDown()
    {
        if (baseManager.reasource >= resourceCost)
        {
            baseManager.reasource -= resourceCost;
            GameObject firstNode = GameObject.Find("PathNode (" + spawnNodeNum + ")");
            BaseSprite instance = Instantiate(enemyType, firstNode.transform.position, Quaternion.identity);

            instance.setVariables(spawnHealth, spawnDamage, movementSpeed, spawnNodeNum, firstNode, endNodeNum);
        }
    }
}