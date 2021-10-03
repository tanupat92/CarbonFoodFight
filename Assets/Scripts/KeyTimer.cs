using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTimer : MonoBehaviour
{
    public KeyManager keyManager; 

    public float keyDelay = 8.0f;
    private float nextKeyTime = 5f;

    private void FixedUpdate()
    {
        if (Time.time >= nextKeyTime)
        {
            keyManager.AddKey();
            nextKeyTime = Time.time + keyDelay; 
            keyDelay *= .99f; 
        }
    }
}
