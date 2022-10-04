using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCube : Interactable
{
    public GameObject particle;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    protected override void Interact()
    {
        Destroy(gameObject);
        Instantiate(particle, transform.position, Quaternion.identity);
        Debug.Log("Dest");
    }
}
