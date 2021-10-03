using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 
public class Ingredient
{
    public enum IngredientName 
    {
        lamb,
        beef,
        pork,
        turkey,
        chicken,
        tuna,
        tofu,
        cheese, 
        milk, 
        yoghurt,
        peanutbutter,
        egg,
        potato,
        broccoli,
        nut,
        tomato,
        rice, 
    }

    public IngredientName ingredientName;

    public Ingredient()
    {
        this.ingredientName = (IngredientName) UnityEngine.Random.Range(0,18); 
    } 

    public Sprite GetSprite()
    {
        switch (ingredientName){
            default:
            case IngredientName.lamb:  return IngredientAssets.Instance.lamb; 
            case IngredientName.beef:   return IngredientAssets.Instance.beef; 
            case IngredientName.pork:   return IngredientAssets.Instance.pork; 
            case IngredientName.turkey:return IngredientAssets.Instance.turkey; 
            case IngredientName.chicken:  return IngredientAssets.Instance.chicken; 
            case IngredientName.tuna:return IngredientAssets.Instance.tuna; 
            case IngredientName.tofu:    return IngredientAssets.Instance.tofu; 
            case IngredientName.cheese: return IngredientAssets.Instance.cheese; 
            case IngredientName.milk: return IngredientAssets.Instance.milk; 
            case IngredientName.yoghurt:  return IngredientAssets.Instance.yoghurt; 
            case IngredientName.peanutbutter:   return IngredientAssets.Instance.peanutbutter; 
            case IngredientName.egg:   return IngredientAssets.Instance.egg; 
            case IngredientName.potato:return IngredientAssets.Instance.potato; 
            case IngredientName.broccoli:  return IngredientAssets.Instance.broccoli; 
            case IngredientName.nut:return IngredientAssets.Instance.nut; 
            case IngredientName.tomato:    return IngredientAssets.Instance.tomato; 
            case IngredientName.rice: return IngredientAssets.Instance.rice; 
        }
    }

    public float GetCarbon()
    {
        switch (ingredientName){
            default : return 0;
            case IngredientName.lamb:  return 39.2f ;
            case IngredientName.beef:   return 27f ;
            case IngredientName.pork:   return 12.1f ;
            case IngredientName.turkey:return 10.9f ;
            case IngredientName.chicken:  return 6.9f ;
            case IngredientName.tuna:return 6.1f ;
            case IngredientName.tofu:    return 2f ;
            case IngredientName.cheese: return 13.5f ;
            case IngredientName.milk: return 1.9f ;
            case IngredientName.yoghurt:  return 2.2f ;
            case IngredientName.peanutbutter:   return 2.5f ;
            case IngredientName.egg:   return 4.8f ;
            case IngredientName.potato:return 2.9f ;
            case IngredientName.broccoli:  return 2f ;
            case IngredientName.nut:return 2.3f ;
            case IngredientName.tomato:    return 1.1f ;
            case IngredientName.rice: return 2.7f ;
        }
    }


    public float GetMile()
    {
        switch (ingredientName){
            default : return 0;
            case IngredientName.lamb:  return 91.0f ;
            case IngredientName.beef:   return 63f ;
            case IngredientName.pork:   return 28f ;
            case IngredientName.turkey:return 25.0f ;
            case IngredientName.chicken:  return 16.0f ;
            case IngredientName.tuna:return 14.0f ;
            case IngredientName.tofu:    return 4.5f ;
            case IngredientName.cheese: return 31.0f ;
            case IngredientName.milk: return 4.5f ;
            case IngredientName.yoghurt:  return 5.2f ;
            case IngredientName.peanutbutter:   return 5.8f ;
            case IngredientName.egg:   return 11f ;
            case IngredientName.potato:return 6.8f ;
            case IngredientName.broccoli:  return 4.8f ;
            case IngredientName.nut:return 5.3f ;
            case IngredientName.tomato:    return 2.5f ;
            case IngredientName.rice: return 6.2f ;
        }
    }

    
    
}
