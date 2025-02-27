using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Controlador_GameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoPunto;

    private void OnEnable()
    {
        ActualizarPuntaje(Controlador_Puntaje.Instancia.ObtenerPuntage());
    }

    public void ActualizarPuntaje(int nuevoPuntaje)
    {
        textoPunto.text = nuevoPuntaje.ToString();
    }
}
