using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDataTransmitter : MonoBehaviour
{
    // Data Transmitter -> dosyalarýn birbirleri ile iletiþim kurmak için oluþturuldu

    [SerializeField] private GroundFallController GroundFallController;

    public void SetGroundRigidbodyValue()
    {
        StartCoroutine(GroundFallController.SetRigidbodyValue());
    }
}
