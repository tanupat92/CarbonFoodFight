using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KeyManager : MonoBehaviour
{
    public Text resultText; 
    public Text resultPlayer1;
    public Text resultPlayer2;
    public GameObject ResultPanel; 

    private List<Key> Keys = new List<Key>();

    public KeySpawner keySpawner; 
    public bool hasActiveKey; 
    public static Key activeKey;
    public static Key destroyKey; 

    [SerializeField]
    private PlayerFood player1Food;
    [SerializeField]
    private PlayerFood player2Food;

    private FoodInventory player1Inventory= new FoodInventory();
    private FoodInventory player2Inventory= new FoodInventory(); 

    public int choice = 6; 

    void Start()
    {

    }

    void Update(){
        if (Keys.Contains(destroyKey)){
            Keys.Remove(destroyKey); 
            hasActiveKey = false; 
            Debug.Log("Really destroy");
        }
    }
     
    public void AddKey(){
        Ingredient ingredient = new Ingredient() ; 
        Key newkey = new Key(randomKey(), keySpawner.SpawnKey(), ingredient);
        Debug.Log(newkey.key);
        Keys.Add(newkey);
    }

    private string randomKey(){
        int a ; 
        string b = "";
        for (int i=0; i<5; i++){
            a = Random.Range(0, 4); 
            b += a.ToString(); 
        }
        return b; 
    }


    public void TypeKey(char letter, bool player1){
        if (hasActiveKey){
            if (activeKey.GetNextLetter() == letter){
                activeKey.TypeKey(player1); 
            }
        }else
        {
            foreach(Key key in Keys){
                if (key.GetNextLetter() == letter){
                    activeKey = key ; 
                    hasActiveKey = true; 
                    key.TypeKey(player1); 
                    break; 
                }
            }
        }


        if (hasActiveKey && activeKey.KeyTyped() is Ingredient && activeKey.KeyTyped() != null && (player1Inventory.GetFoodList().Count <=choice || player2Inventory.GetFoodList().Count <=choice))
        {
            Ingredient food = activeKey.KeyTyped() ; 
            hasActiveKey = false;
            Keys.Remove(activeKey);
            Debug.Log("REMOVE ACTIVE KEY");

            if (player1Inventory.GetFoodList().Count >=choice && player2Inventory.GetFoodList().Count >=choice){
                foreach (Ingredient i in player1Inventory.GetFoodList()){
                    GameManager.instance.Score1 += i.GetCarbon();
                    GameManager.instance.Score1Mile += i.GetMile();
                }

                foreach (Ingredient j in player2Inventory.GetFoodList()){
                    GameManager.instance.Score2 += j.GetCarbon();
                    GameManager.instance.Score2Mile += j.GetMile();
                }
                if (GameManager.instance.Score1 > GameManager.instance.Score2){
                    resultText.text = "Red wins!   Player Blue ruins the Earth"; 
                }
                else if (GameManager.instance.Score1 < GameManager.instance.Score2){
                    resultText.text = "Blue wins!   Player Red ruins the Earth"; 
                }
                else{
                    resultText.text = "Draw!"; 
                }

                resultPlayer1.text = "Red produces " + GameManager.instance.Score1.ToString() + " kg of CO2 equals to drive "+ GameManager.instance.Score1Mile.ToString() + " miles"; 
                resultPlayer2.text = "Blue produces " + GameManager.instance.Score2.ToString() + " kg of CO2 equals to drive "+ GameManager.instance.Score2Mile.ToString() + " miles"; 
                ResultPanel.SetActive(true); 
            }

            if (player1){
                player1Inventory.AddFood(food);
                player1Food.SetInventory(player1Inventory);
            }
            else{
                player2Inventory.AddFood(food);
                player2Food.SetInventory(player2Inventory);
            }

            
            
          

            
        }

        
    }

    public void RemoveOutScreen(Key _activeKey){
        Keys.Remove(_activeKey); 
    }
}
