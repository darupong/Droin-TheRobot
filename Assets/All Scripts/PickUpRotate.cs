using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRotate : MonoBehaviour
{
   public float rotateSpeed;

    private void Start(){
        rotateSpeed = Random.Range(1f, 5f) * rotateSpeed;
    }
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 45)*rotateSpeed * Time.deltaTime);
    }
}
