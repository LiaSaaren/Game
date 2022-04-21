using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public void OnHit()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * 1600f);
        GetComponent<Rigidbody>().AddTorque(800f, 0f, 0f);
    }
}
