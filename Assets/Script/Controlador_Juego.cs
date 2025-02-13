using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador_Juego : MonoBehaviour
{
    public static Controlador_Juego Instania;

    public delegate void EventosJuegosDelegado();

    public EventosJuegosDelegado JuegoIniciadoEvento;
    public EventosJuegosDelegado JuegoPausadoEvento;
    public EventosJuegosDelegado JuegoReanudadoEvento;
    public EventosJuegosDelegado JuegoFinalizadoEvento;

    private void Awake()
    {
        if (Instania == null)
        {
            Instania = this;
        }

        else
        {
            Destroy(gameObject);
        }
        Time.timeScale = 0f;
    }

    public void IniciarJuego()
    {
        JuegoIniciadoEvento?.Invoke();
    }

    public void PausarJuego()
    {
        JuegoPausadoEvento?.Invoke();
    }

    public void FinJuego()
    {
        JuegoFinalizadoEvento?.Invoke();
    }

    public void ReanudarJuego()
    {
        JuegoReanudadoEvento?.Invoke();
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }
}
