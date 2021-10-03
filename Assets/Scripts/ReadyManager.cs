using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems ; 

public class ReadyManager : MonoBehaviour
{
    public GameObject bg;
    public GameObject IngredientHolder;
    public Text readyText; 
    private float time=0 ; 
    // Start is called before the first frame update
    void Update()
    {
        time += Time.deltaTime; 
        if (time <2f){
            readyText.text = "Ready";
        }
        else if (time <3f){
            readyText.text = "3";
        }
        else if (time <4f){
            readyText.text = "2";
        }
        else if (time <5f){
            readyText.text = "1";
        }
        else if (time >5f){
            bg.SetActive(false); 
            IngredientHolder.SetActive(true); 
        }
        
        
    }
}
