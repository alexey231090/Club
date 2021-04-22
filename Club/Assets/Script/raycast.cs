using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    public GameObject obj;
    Vector3 Doorposition;
    public Door door;
    void Start()
    {
       Doorposition = obj.transform.position;
      
    }

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward); 
        Debug.DrawRay(transform.position, transform.forward * 100, Color.yellow);
        print(door.OpenClose);


        if (Physics.Raycast(ray) && door.OpenClose == true && Input.GetKeyDown(KeyCode.E))
        {

            obj.transform.position = new Vector3(Doorposition.x, Doorposition.y, -8.25f);

        }
        else if (!Physics.Raycast(ray))
        {
            return;
        }
            
       
    }

    

}
