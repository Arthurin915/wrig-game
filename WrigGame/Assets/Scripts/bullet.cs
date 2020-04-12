using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider) 
    {
        if(collider.transform.tag == "Enemy") {
            print(collider.transform.name);
            collider.gameObject.SendMessage("takeDamage", 20);
        }
    }
}
