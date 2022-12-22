using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SC0 : MonoBehaviour
{
    [SerializeField] private Renderer myObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Can"))
        {
            myObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Can"))
        {
            myObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        }
    }
}