using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColorController : MonoBehaviour
{
    [SerializeField] private Material GroundMaterial; // Ground material'ine ihtiyac�m�z var
    [SerializeField] private Color[] Colors;
    [SerializeField] private float LerpValue;
    [SerializeField] private float Time;

    private int ColorIndex = 0; // Index'i artt�rarak Color dizisinin i�inde dola�mam�z� sa�layacak
    private float CurrentTime;


    private void Update()
    {
        SetColorChangeTime();
        SetGroundMaterialSmoothColorChange();
    }

    private void SetColorChangeTime() // Renk de�i�imi i�in zamanlay�c� fonksiyonu
    {
        if (CurrentTime <= 0)
        {
            CheckColorIndexValue();
            CurrentTime = Time;
        }
        else
        {
            CurrentTime -= UnityEngine.Time.deltaTime;
        }
    }

    private void CheckColorIndexValue()
    {
        ColorIndex++;

        if (ColorIndex >= Colors.Length)
        {
            ColorIndex = 0;
        }
    }

    private void SetGroundMaterialSmoothColorChange() // Yumu�ak renk ge�i�i i�in 
    {
        GroundMaterial.color = Color.Lerp(GroundMaterial.color, Colors[ColorIndex], LerpValue * UnityEngine.Time.deltaTime);
    }

    private void OnDestroy() 
    {
        GroundMaterial.color = Colors[1]; // her oyun ba�lang�c�nda 1. renk olsun
    }
}
