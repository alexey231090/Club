using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
   public bool OpenClose = false;
    void Start()
    {
         bool OpenClose = false;
}

   
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) // Вход или касание 
    {

        if (other.tag == "Player")
        {
            OpenClose = true;
        }
        else if(other.tag != "Player")

        {
            OpenClose = false;
        }
    }

  
}
