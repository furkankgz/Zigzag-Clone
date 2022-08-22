using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColorController : MonoBehaviour
{
    [SerializeField] private Material GroundMaterial; // Ground material'ine ihtiyacýmýz var
    [SerializeField] private Color[] Colors;
    [SerializeField] private float LerpValue;
    [SerializeField] private float Time;

    private int ColorIndex = 0; // Index'i arttýrarak Color dizisinin içinde dolaþmamýzý saðlayacak
    private float CurrentTime;


    private void Update()
    {
        SetColorChangeTime();
        SetGroundMaterialSmoothColorChange();
    }

    private void SetColorChangeTime() // Renk deðiþimi için zamanlayýcý fonksiyonu
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

    private void SetGroundMaterialSmoothColorChange() // Yumuþak renk geçiþi için 
    {
        GroundMaterial.color = Color.Lerp(GroundMaterial.color, Colors[ColorIndex], LerpValue * UnityEngine.Time.deltaTime);
    }

    private void OnDestroy() 
    {
        GroundMaterial.color = Colors[1]; // her oyun baþlangýcýnda 1. renk olsun
    }
}
