using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Keypadcode : Interactable
{
    [SerializeField]
    private GameObject door;
    private bool doorOpen;
    [SerializeField]
    private TextMeshProUGUI CodeText;
    string codeTextValue = "";
    public string safeCode;
    public GameObject CodePanel;
    public void AddDigit(string digit)
    {
        codeTextValue += digit;
        if (digit == "-")
        {
            CodePanel.SetActive(false);
            codeTextValue = "";
        }
        if (digit == "/")
        {
            codeTextValue = "";
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CodeText.text = codeTextValue;
        if (codeTextValue.Length > 4)
        {
            codeTextValue = "";
        }
        if (codeTextValue == safeCode)
        {
            doorOpen = !doorOpen;
            door.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
            CodePanel.SetActive(false);
        }

    }
    protected override void Interact()
    {
        CodePanel.SetActive(true);
    }

}