using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSimulate : MonoBehaviour
{
    public float WaterDensity = 10f;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float divePercent = -transform.position.y + transform.localScale.x * 0.5f;
        divePercent = Mathf.Clamp(divePercent, 0f, 2f);

        _rigidbody.AddForce(Vector3.up * divePercent * WaterDensity);
        _rigidbody.drag = divePercent * 3f;
        _rigidbody.angularDrag = divePercent * 3f;
    }

}
