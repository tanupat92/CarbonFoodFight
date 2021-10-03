using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
using System.Text;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;  
    

    private float _score1=0;
    public float Score1{
        get { return _score1;}
        set { _score1 = value;}
    }

    private float _score2=0;
    public float Score2{
        get { return _score2;}
        set { _score2 = value;}
    }

    private float _score3=0;
    public float Score1Mile{
        get { return _score3;}
        set { _score3 = value;}
    }

    private float _score4=0;
    public float Score2Mile{
        get { return _score4;}
        set { _score4 = value;}
    }


    public void Reset(){
        _score1 = 0;
        _score2 = 0;
        _score3 = 0;
        _score4 = 0; 
    }


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } 
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()   
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode){
        if (scene.name == "GamePlay")
        {
            Debug.Log("At scene GamePlay"); 
        } 
        else if (scene.name == "MainMenu")
        {
            Reset(); 
            Debug.Log("At scene MainMenu"); 

        }
       
    }
   
}


