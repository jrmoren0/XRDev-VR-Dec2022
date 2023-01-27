using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    [SerializeField]
    private GameObject[] foodPrefabs;



    public void CreateFood()
    {
        int randIndex = Random.Range(0, foodPrefabs.Length);
        GameObject randomPrefab = foodPrefabs[randIndex];
        Instantiate(randomPrefab, transform.position, Random.rotation);
    }
}
