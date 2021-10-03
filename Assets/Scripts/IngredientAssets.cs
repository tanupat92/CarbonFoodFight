using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientAssets : MonoBehaviour
{
    public static IngredientAssets Instance 
    {
        get;
        private set; 
    }

    private void Awake()
    {
        Instance = this; 
    }

    public Sprite lamb;
    public Sprite beef;
    public Sprite pork;
    public Sprite turkey;
    public Sprite chicken;
    public Sprite tuna;
    public Sprite tofu;
    public Sprite cheese; 
    public Sprite milk; 
    public Sprite yoghurt;
    public Sprite peanutbutter;
    public Sprite egg;
    public Sprite potato;
    public Sprite broccoli;
    public Sprite nut;
    public Sprite tomato;
    public Sprite rice; 
}
