using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador_Paneles : MonoBehaviour
{
    [SerializeField]GameObject panelInicio, panelFinalizado, panelPausa, panelHUD;

    private void OnEnable()
    {
        Controlador_Juego.Instania.JuegoIniciadoEvento += MostrarHUd;
        Controlador_Juego.Instania.JuegoFinalizadoEvento += MostrarFinalizado;
        Controlador_Juego.Instania.JuegoPausadoEvento += MostrarPausa;
        Controlador_Juego.Instania.JuegoReanudadoEvento += MostrarHUd;
    }

    public void MostrarPausa()
    {
        panelPausa.SetActive(true);
        panelFinalizado.SetActive(false);
        panelInicio.SetActive(false);
        panelHUD.SetActive(false); 
    }

    public void MostrarInicio()
    {
        panelPausa.SetActive(false);
        panelFinalizado.SetActive(false);
        panelInicio.SetActive(true);
        panelHUD.SetActive(false);
    }

    public void MostrarFinalizado()
    {
        panelPausa.SetActive(false);
        panelFinalizado.SetActive(true);
        panelInicio.SetActive(false);
        panelHUD.SetActive(false);
    }

    public void MostrarHUd()
    {
        panelPausa.SetActive(false);
        panelFinalizado.SetActive(false);
        panelInicio.SetActive(false);
        panelHUD.SetActive(true);
    }
}
