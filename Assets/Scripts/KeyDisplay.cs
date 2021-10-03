using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyDisplay : MonoBehaviour
{
    public KeyManager KeyManager; 
    public Text text; 
    public Image image; 
    public string key ; 
    //public Text score; 
    public void SetKey(string word)
    {
        text.text = word; 
    }

    public void SetIngredient(Ingredient ingredient)
    {
        image.sprite = ingredient.GetSprite(); 
    }

    public void SetName(string _key){
        key = _key ; 
    }

    public void RemoveLetter(bool player1){
        text.text = text.text.Remove(0,1);
        
        if(player1){
            text.color = Color.red; 
        } 
        else{
            text.color = Color.blue; 
        }
    }

    public void RemoveWord(Ingredient ingredient)
    {
        Debug.Log(ingredient.GetCarbon()); 
        Destroy(gameObject); 
    }

    void Update(){
        if (transform.position.y <-6f){
            if (KeyManager.activeKey != null){
                if (KeyManager.activeKey.key == key){
                    KeyManager.destroyKey = KeyManager.activeKey; 
                    Debug.Log("Destroy"); 
                } 
            }
        }
    }
}
