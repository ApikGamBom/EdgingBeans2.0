using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    public Camera Camera;
    public float rayLength = 2f;
    public LayerMask interactable;

    void Update()
    {
        RaycastHit hit;

        //Lager en Ray så jeg ikke må skrive alt hver gang jeg bruker den
        Ray ray = Camera.transform.GetComponent<Ray>();

        if (Physics.Raycast(Camera.transform.position, Camera.transform.forward, out hit, rayLength))
        {
        }
    }
}
