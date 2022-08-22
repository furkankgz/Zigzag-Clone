using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundFallController : MonoBehaviour
{
    private Rigidbody Rb;


    private void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    public IEnumerator SetRigidbodyValue()
    {
        yield return new WaitForSeconds(.75f);
        Rb.useGravity = true;
        Rb.isKinematic = false;
    }
}
