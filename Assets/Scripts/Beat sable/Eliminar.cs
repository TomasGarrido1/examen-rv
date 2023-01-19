using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eliminar : MonoBehaviour
{
    
   private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("colision");
        
        if (collision.gameObject.name == "Pared_trasera" || collision.gameObject.tag == "Espadas")
        {   
            Destroy(gameObject);
            Debug.Log("Roto");
        }
    }
}
