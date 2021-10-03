using System ; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems; 
public class PlayerFood : MonoBehaviour
{
    private FoodInventory inventory;
    private Transform foodSlotContainer;
    private Transform foodSlotImage;
    private Transform foodText;
    private Transform carbonText;
    private Transform parent;

    private void Start()
    {
        foodSlotContainer = this.transform;
        foodSlotImage = foodSlotContainer.Find("Image");
        
        
    }
    public void SetInventory(FoodInventory inventory)
    {
        this.inventory = inventory; 
        foodSlotContainer = this.transform;
        foodSlotImage = foodSlotContainer.Find("Image");
        foreach (Transform child in foodSlotContainer) {
            if (child.gameObject.name != "Image"){
                GameObject.Destroy(child.gameObject);
            }
        }
        RefreshInventoryGames(); 
    }
    private void RefreshInventoryGames()
    {
        foreach (Ingredient ingredient in inventory.GetFoodList())
        {
            
            Transform foodSlot = Instantiate(foodSlotImage, foodSlotContainer); 
            parent = foodSlot.Find("Parent");
            foodText = parent.Find("foodText"); 
            carbonText = parent.Find("carbonText"); 

            RectTransform foodSlotRectTransform = foodSlot.GetComponent<RectTransform>(); 
            foodSlotRectTransform.gameObject.SetActive(true);
            foodSlotRectTransform.gameObject.GetComponent<Image>().sprite = ingredient.GetSprite(); 
            
            foodText.GetComponent<Text>().text = ingredient.ingredientName.ToString();
            carbonText.GetComponent<Text>().text = ingredient.GetCarbon().ToString();  
            
            
        }
    }
    
  
        

}
