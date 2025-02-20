using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        Time.timeScale = 1f;
        JuegoIniciadoEvento?.Invoke();
    }

    public void PausarJuego()
    {
        Time.timeScale = 0f;
        JuegoPausadoEvento?.Invoke();
    }

    public void FinJuego()
    {
        Time.timeScale = 0f;
        JuegoFinalizadoEvento?.Invoke();
    }

    public void ReanudarJuego()
    {
        Time.timeScale = 1f;

        JuegoReanudadoEvento?.Invoke();
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }

    public void ReiniciarJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
