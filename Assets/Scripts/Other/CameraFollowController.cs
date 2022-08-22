using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    [SerializeField] private Transform BallTransform;
    private Vector3 Offset;
    private Vector3 NewPosition;
    [SerializeField] [Range(0, 3)] private float LerpValue;

    void Start()
    {
        Offset = transform.position - BallTransform.position; // aradaki mesafe offset'e aktarýldý
    }
    
    void LateUpdate() 
    {
        SetCameraSmoothFollow();
    }

    private void SetCameraSmoothFollow() // Camera'nýn topu takip etmesi için gerekli fonksiyon
    {
        NewPosition = Vector3.Lerp(transform.position, BallTransform.position + Offset, LerpValue * Time.deltaTime); 
        transform.position = NewPosition;
    }
}
