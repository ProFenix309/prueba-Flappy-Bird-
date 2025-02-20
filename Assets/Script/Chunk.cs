using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    [SerializeField] List<Transform> pivotes = new List<Transform>();
    [SerializeField]List<GameObject> obstaculosInstanciados = new List<GameObject>();

    [SerializeField] bool instanciar;

    // Start is called before the first frame update
    void Start()
    {
        if (instanciar) 
        {
            GenerarOptaculos();
        }
    }
    
    public void GenerarOptaculos()
    {
        EliminarObstacilos();

        for (int i = 0; i < pivotes.Count; i++)
        {
            int numeroAleatorio = Random.Range(1,6);
            GameObject obstaculo = (GameObject)Instantiate(Resources.Load("Obstaculo " + numeroAleatorio), pivotes[i]);
            obstaculo.transform.localPosition = Vector3.zero;
            obstaculosInstanciados.Add(obstaculo);
        }
    }
    public void EliminarObstacilos()
    {
        for(int i = 0;  i < obstaculosInstanciados.Count; i++)
        {
            Destroy(obstaculosInstanciados[i]);
        }

        obstaculosInstanciados.Clear();
    }
}
