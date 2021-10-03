using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Key  
{
    public string key;
    public Ingredient ingredient; 
    private int typeIndex; 

    public KeyDisplay display; 

    public Key(string _key, KeyDisplay _display, Ingredient _name){
        this.key = _key; 
        this.ingredient = _name; 
        typeIndex = 0 ; 
        display = _display ; 
        display.SetKey(this.key); 
        display.SetIngredient(ingredient); 
        display.SetName(_key); 
    }
    
    public char GetNextLetter(){
        return key[typeIndex]; 
    }

    public void TypeKey(bool player1){
        typeIndex++;
        display.RemoveLetter(player1); 
    }

    public Ingredient KeyTyped(){
            bool keyTyped = (typeIndex >= key.Length); 
            if (keyTyped)
            {
                display.RemoveWord(ingredient); 
                return ingredient; 
            }
            else {
                return null; 
            }

            
        }
}
