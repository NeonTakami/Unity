using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class OpenNote : Interactable
{
    [SerializeField]
    private GameObject note;   
    [SerializeField]
    private TextMeshProUGUI CodeText;
    string codeTextValue = "";
    public GameObject CodePanel;
    public void AddDigit(string digit)
    {
        codeTextValue += digit;
        if (digit == "-")
        {
            CodePanel.SetActive(false);
            codeTextValue = "";
        }       
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    protected override void Interact()
    {
        note.SetActive(true);
    }
}