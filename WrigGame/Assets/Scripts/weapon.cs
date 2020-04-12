using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public GameObject bullet;

    public GameObject bulletEmitter;

    public float nextTimeToFire = 0f;

    public float fireRate = 1f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire) {
            shoot();
            nextTimeToFire = Time.time + 1f/fireRate;
        }
    }

    void shoot() 
    {
        GameObject tempBullet;

        tempBullet = Instantiate(bullet, bulletEmitter.transform.position, bulletEmitter.transform.rotation);

        tempBullet.transform.Rotate(Vector3.up * 90);

        tempBullet.transform.rotation = Quaternion.LookRotation(Vector3.forward);

        Rigidbody tempBody = tempBullet.GetComponent<Rigidbody>();

        tempBody.AddForce(Camera.main.transform.forward * 4000f);

        Destroy(tempBullet, 3f);
    }
}
