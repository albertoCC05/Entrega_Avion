using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    //variables

    [SerializeField] private float forwardSpeed;
    [SerializeField] private float rotatetSpeed;
    private float verticalImput;
    [SerializeField] private GameObject Camera;
    [SerializeField] private Vector3 offset;
    private int messageWin = 0;



    //logica movimiento

    private void Update()
    {
        verticalImput=Input.GetAxis("Vertical");

      

        Camera.transform.position = transform.position + offset;

        if (transform.position.z >= (220) && messageWin==0)
        {
            Debug.Log("you win");

            forwardSpeed = 0;
            rotatetSpeed = 0;

            messageWin = 1;      

        }
        else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed);

            transform.Rotate(new Vector3(1, 0, 0) * Time.deltaTime * rotatetSpeed * verticalImput);
        }

    }
}
