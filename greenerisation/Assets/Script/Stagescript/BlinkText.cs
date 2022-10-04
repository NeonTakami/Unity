using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlinkText : MonoBehaviour
{
    private TextMeshProUGUI text;
    public float blinkRate;

    void Start()
    {
        StartCoroutine(BlinkObject());
    }

    IEnumerator BlinkObject()
    {
        float time = 0f;
        text = GetComponent<TextMeshProUGUI>();
        while (true)
        {
            Color newcolor = text.color;
            newcolor.a = Mathf.Sin(time * blinkRate) / 2 + 0.5f;
            text.color = newcolor;
            time += Time.deltaTime;
            yield return null;
        }
    }
}