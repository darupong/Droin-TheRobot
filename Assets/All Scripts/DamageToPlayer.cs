using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageToPlayer : MonoBehaviour
{
      private void OnCollisionEnter2D(Collision2D other) 
      {
       
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene(1);
        }
    
      }   
    
}
  
    

    
    
    
 
