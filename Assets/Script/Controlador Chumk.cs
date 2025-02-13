using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorChumk : MonoBehaviour
{

    [SerializeField] List<Chunk> chunk = new List<Chunk>();
    [SerializeField] Transform ultimoChunk;

    [SerializeField] float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < chunk.Count; i++)
        {
            if (chunk[i].transform.position.x <= -7)
            {
                chunk[i].transform.position = ultimoChunk.position + (Vector3.right * 7);
                ultimoChunk = chunk[i].transform;
                chunk[i].GenerarOptaculos();
            }

            chunk[i].transform.Translate(Vector3.left * velocidad * Time.deltaTime, Space.World);
        }
    }
}
