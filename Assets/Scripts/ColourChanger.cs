using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            GetComponent<Renderer>().material.color = GetRandomColour();
        }
    }

    private Color GetRandomColour()
    {
        return new Color(UnityEngine.Random.Range(0, 1f), UnityEngine.Random.Range(0, 1f), UnityEngine.Random.Range(0, 1f));
    }
}
