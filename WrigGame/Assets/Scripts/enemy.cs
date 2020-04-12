using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private float healthBar = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void takeDamage(float damage) {
        healthBar -= damage;
        print(healthBar);

        if (healthBar == 0) {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
                   
    }
}
