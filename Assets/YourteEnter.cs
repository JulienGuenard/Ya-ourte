using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YourteEnter : MonoBehaviour
{
    public Color colorEnter;
    public Color colorExit;
    public float alpha;
    Color colorYourteStart;
    Color colorYourtePorteStart;

    public MeshRenderer yourte;
    public MeshRenderer yourtePorte;

    // Start is called before the first frame update
    void Awake()
    {
        colorYourteStart = yourte.material.color;
        colorYourtePorteStart = yourtePorte.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Color newColor = colorYourteStart;
            newColor.a = alpha;
            yourte.material.color = newColor;
            newColor = colorYourtePorteStart;
            newColor.a = alpha;
            yourtePorte.material.color = newColor;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            yourte.material.color = colorYourteStart;
            yourtePorte.material.color = colorYourtePorteStart;
        }
    }
}
