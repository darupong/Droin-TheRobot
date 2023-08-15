using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public Text endText;
    private bool Endgame;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp03") || Endgame)
        {
             
            endText.text = "to be continued...";
            Time.timeScale = 0;
             
        }
    }
    void Start(){
        Initialize();
    }
    private void Update(){
        UIHandler();
        RageQuit();
    }
    private void Initialize()
    {
        endText.text = "";
        Endgame = false;
    } 
    private void UIHandler()
    {
        if (Endgame){
            endText.text = "to be continued...";
    }
        
            
        
    }
    private void RageQuit(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
}
}