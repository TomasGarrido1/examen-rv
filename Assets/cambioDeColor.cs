using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class cambioDeColor : MonoBehaviour
{
    XRBaseInteractable m_Interactable;
    Renderer m_Renderer;
    // Start is called before the first frame update
    void Start()
    {
        m_Interactable = GetComponent<XRBaseInteractable>();

        m_Renderer = GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     protected void OnEnable()
    {
        m_Interactable = GetComponent<XRBaseInteractable>();
        m_Renderer = GetComponent<Renderer>();

        CambioColor();
    }


    protected void CambioColor()
    {
        m_Renderer.material.color = Color.green;//new UnityEngine.Color(47,255,0,255);
    }
}
