using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptScore : MonoBehaviour
{
    public Text countText;
    public int count;
void Start(){
    Initialize();
}
    private void Initialize()
    {
        count = 0;
        SetCountText();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("PickUp01"))
        {   other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText ();
        }
        else if (other.gameObject.CompareTag("PickUp02"))
        {
             other.gameObject.SetActive(false);
             count = count + 5;
             SetCountText();
        }
        else if (other.gameObject.CompareTag("PickUp03"))
        {
             
              SceneManager.LoadScene(3);
             
        }
        }
        void SetCountText() {
        countText.text = "Score : " + count.ToString();
    }
}
    
