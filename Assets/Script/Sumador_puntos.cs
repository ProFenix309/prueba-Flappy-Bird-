using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sumador_puntos : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Controlador_Puntaje.Instancia.SumarPunto();
            
        }
    }
}
