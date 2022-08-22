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
        if (Input.GetMouseButtonDown(0)) // Topun yönünü deðiþtirmek için atadýðýmýz buton fonksiyonu
        {
            ChangeBallDirection();
        }
    }

    private void ChangeBallDirection() // Topun yönünü deðiþtirmek için kullandýðýmýz fonksiyon
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
