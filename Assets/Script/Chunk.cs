using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    [SerializeField] List<Transform> pivotes = new List<Transform>(); 

    // Start is called before the first frame update
    void Start()
    {
        GenerarOptaculos();
    }

    public void GenerarOptaculos()
    {
        for (int i = 0; i < pivotes.Count; i++)
        {
            GameObject obstaculo = (GameObject)Instantiate(Resources.Load("Obstaculo 1"), pivotes[i]);
            obstaculo.transform.localPosition = Vector3.zero;
        }
    }
}
