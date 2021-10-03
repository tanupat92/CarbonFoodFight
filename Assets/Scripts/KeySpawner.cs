using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawner : MonoBehaviour
{
    public GameObject keyPrefab; 
    public Transform keyCanvas; 
    public KeyDisplay SpawnKey()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-8f, 8f), 7f);

        GameObject keyObj = Instantiate(keyPrefab, randomPosition, Quaternion.identity, keyCanvas);
        KeyDisplay keyDisplay = keyObj.GetComponent<KeyDisplay>(); 

        return keyDisplay; 
    }
}
