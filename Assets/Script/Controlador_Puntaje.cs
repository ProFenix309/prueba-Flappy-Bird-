using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador_Puntaje : MonoBehaviour
{
    public static Controlador_Puntaje Instancia;

    public delegate void ActualisacionesDelegate(int puntaje);
    public ActualisacionesDelegate PuntajeActualizado;
    public ActualisacionesDelegate MejorPuntajeActualizado;

    public delegate void ActivarParticle();
    public ActivarParticle activarParticle;

     private int puntajeAcual = 0;
     private int mejorPuntaje = 0;

    private void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
        }
        else
        {
            Destroy(gameObject);
        }

        Controlador_Juego.Instania.JuegoFinalizadoEvento += GuardarPuntaje;
    }
    private void Start()
    {
        CagarMejorPuntaje();
    }

    public void SumarPunto()
    {
        puntajeAcual++;
        PuntajeActualizado?.Invoke(puntajeAcual);
        activarParticle?.Invoke();
    }

    public void CagarMejorPuntaje()
    {
        if (PlayerPrefs.HasKey("Mejor_Puntaje"))
        {
            mejorPuntaje = PlayerPrefs.GetInt("Mejor_Puntaje");
            MejorPuntajeActualizado.Invoke(mejorPuntaje);
        }
    }

    public void GuardarPuntaje()
    {
        if (puntajeAcual > mejorPuntaje)
        {
            PlayerPrefs.SetInt("Mejor_Puntaje", puntajeAcual);
        }    
    }

    public int ObtenerPuntage()
    {
        return puntajeAcual; 
    }

   
}
