using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elixmovment : MonoBehaviour
{
    [SerializeField] private float rotationSpeedElix;

    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * rotationSpeedElix);
    }

  
}
