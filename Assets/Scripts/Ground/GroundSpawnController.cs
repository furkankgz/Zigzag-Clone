using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnController : MonoBehaviour
{
    public GameObject LastGroundObject;
    [SerializeField] private GameObject GroundPrefab;
    private GameObject NewGroundObject;
    private int GroundDirection;

    void Start()
    {
        GenerateRandomNewGrounds();
    }

    private void GenerateRandomNewGrounds()
    {
        for (int i = 0; i < 75; i++)
        {
            CreateNewGround();
        }
    }

    private void CreateNewGround() // Prefab'daki ground'u random olarak sola veya ileriye eklemek için kullandýðýmýz fonksiyon
    {
        GroundDirection = Random.Range(0, 2);

        if (GroundDirection == 0)
        {
            NewGroundObject = Instantiate(GroundPrefab, new Vector3(LastGroundObject.transform.position.x - 1f, LastGroundObject.transform.position.y, LastGroundObject.transform.position.z), Quaternion.identity);
            LastGroundObject = NewGroundObject;
        }
        else
        {
            NewGroundObject = Instantiate(GroundPrefab, new Vector3(LastGroundObject.transform.position.x, LastGroundObject.transform.position.y, LastGroundObject.transform.position.z + 1f), Quaternion.identity);
            LastGroundObject = NewGroundObject;
        }
    }
}
