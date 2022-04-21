using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCreator : MonoBehaviour
{
    public GameObject BilletPrefab;
    public float BulletVelocity = 200f;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            GameObject newBullet = Instantiate(BilletPrefab, transform.position, transform.rotation);
            newBullet.GetComponent<Rigidbody>().velocity = transform.forward * BulletVelocity;
        }
    }
}
