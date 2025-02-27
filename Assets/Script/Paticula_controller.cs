using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paticula_controller : MonoBehaviour
{

    [SerializeField] ParticleSystem particulas;
    // Start is called before the first frame update
    void Start()
    {
        particulas = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void PaticulaPuntos ()
    {
        particulas.Play();
    }

    void PaticulaMuerte()
    {
        particulas.Play();
    }

}
