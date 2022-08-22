using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPositionController : MonoBehaviour
{
    [SerializeField] private float EndYValue;

    private GroundSpawnController GroundSpawnController;
    private Rigidbody Rb;
    private int GroundDirection;

    void Start()
    {
        GroundSpawnController = FindObjectOfType<GroundSpawnController>();
        Rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        CheckGroundVerticalPosition();
    }

    private void CheckGroundVerticalPosition()
    {
        if (transform.position.y <= EndYValue)
        {
            SetRigidbodyValues();
            SetGroundNewPosition();
        }
    }

    private void SetGroundNewPosition()
    {
        GroundDirection = Random.Range(0, 2);

        if (GroundDirection == 0)
        {
            transform.position = new Vector3(GroundSpawnController.LastGroundObject.transform.position.x - 1f, GroundSpawnController.LastGroundObject.transform.position.y, GroundSpawnController.LastGroundObject.transform.position.z);
        }
        else
        {
            transform.position = new Vector3(GroundSpawnController.LastGroundObject.transform.position.x, GroundSpawnController.LastGroundObject.transform.position.y, GroundSpawnController.LastGroundObject.transform.position.z + 1f);
        }

        GroundSpawnController.LastGroundObject = gameObject;
    }

    private void SetRigidbodyValues()
    {
        Rb.isKinematic = true;
        Rb.useGravity = false;
    }
}
