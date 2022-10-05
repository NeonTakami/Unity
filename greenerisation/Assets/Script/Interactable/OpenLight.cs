using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OpenLight : Interactable
{
    [SerializeField]
    private GameObject light;

    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {

    }
    protected override void Interact()
    {
        light.SetActive(true);
    }
}
