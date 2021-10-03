using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodInventory 
{
    private List<Ingredient> ingredientList; 

    public FoodInventory()
    {
        ingredientList = new List<Ingredient>(); 
    }

    public void AddFood(Ingredient ingredient)
    {
        ingredientList.Add(ingredient); 
    }
    public List<Ingredient> GetFoodList()
    {
        return ingredientList; 
    }
}
