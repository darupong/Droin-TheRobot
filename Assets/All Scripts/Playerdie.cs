﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerdie : MonoBehaviour
{
   void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y < -7){
            Die();
        }
    }

    void Die(){
        SceneManager.LoadScene(2);
    }
}
