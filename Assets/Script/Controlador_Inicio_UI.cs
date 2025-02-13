using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Controlador_Inicio_UI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Texto_puntos;

    public void ActualizarPuntaje(int nuevoPuntaje)
    {
        Texto_puntos.text = nuevoPuntaje.ToString();
    }

}
