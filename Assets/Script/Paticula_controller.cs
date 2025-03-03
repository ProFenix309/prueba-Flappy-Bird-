using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paticula_controller : MonoBehaviour
{
    [SerializeField] ParticleSystem particulasPuntos,particulasMuerte;

    private void Update()
    {
        Controlador_Puntaje.Instancia.activarParticle += ActivarParticulaPuntos;
        Controlador_Juego.Instania.JuegoFinalizadoEvento += ActivarParticulaMuerte;
    }


    void ActivarParticulaPuntos()
    {
        particulasPuntos.Play();
    }
    void ActivarParticulaMuerte()
    {
        particulasMuerte.Play();
    }

}
