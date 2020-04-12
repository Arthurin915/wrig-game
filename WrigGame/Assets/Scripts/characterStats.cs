using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterStats : MonoBehaviour
{
    public float baseDamage = 20;

    public float baseHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void modifyDamage(float modifier) {
        baseDamage += modifier * baseDamage;
    }

    void modifyHealth(float modifier) {
        baseHealth += modifier * baseHealth;
    }
}
