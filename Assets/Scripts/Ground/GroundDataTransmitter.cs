using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDataTransmitter : MonoBehaviour
{
    // Data Transmitter -> dosyalar�n birbirleri ile ileti�im kurmak i�in olu�turuldu

    [SerializeField] private GroundFallController GroundFallController;

    public void SetGroundRigidbodyValue()
    {
        StartCoroutine(GroundFallController.SetRigidbodyValue());
    }
}
