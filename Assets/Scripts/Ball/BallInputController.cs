using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInputController : MonoBehaviour
{
    [HideInInspector] public Vector3 BallDirection;
    
    void Start()
    {
        BallDirection = Vector3.left;
    }
    
    void Update()
    {
        HandleBallInputs();
    }

    private void HandleBallInputs() 
    {
        if (Input.GetMouseButtonDown(0)) // Topun y�n�n� de�i�tirmek i�in atad���m�z buton fonksiyonu
        {
            ChangeBallDirection();
        }
    }

    private void ChangeBallDirection() // Topun y�n�n� de�i�tirmek i�in kulland���m�z fonksiyon
    {
        if (BallDirection.x == -1)
        {
            BallDirection = Vector3.forward;
        }
        else
        {
            BallDirection = Vector3.left;
        }
    }
}
