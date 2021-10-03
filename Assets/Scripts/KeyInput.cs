using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour
{
    public KeyManager KeyManager; 
    // Update is called once per frame
    void Update()
    {
        foreach (char letter in Input.inputString)
        {
            bool player1 = false; 
            char l ; 
            if (letter == 'w' || letter == 'i'){
                l = '0';
            }
            else if (letter == 'a' || letter == 'j'){
                l = '1'; 
            }
            else if (letter == 's'|| letter == 'k'){
                l = '2'; 
            }
            else if (letter == 'd'|| letter == 'l'){
                l = '3'; 
            }
            else {
                l = letter ; 
            }

            if (letter == 'w' || letter=='a' || letter=='s' || letter=='d'){
                player1=true; 
            }
            
            KeyManager.TypeKey(l, player1); 
            Debug.Log(letter); 
        }
    }
}
