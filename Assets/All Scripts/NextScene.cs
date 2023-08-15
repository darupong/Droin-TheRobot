using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
     private void OnCollisionEnter2D(Collision2D other) 
      {
       
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);

    
      }   
    }

}