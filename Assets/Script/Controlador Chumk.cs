using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorChumk : MonoBehaviour
{

    [SerializeField] List<Transform> chunk = new List<Transform>();
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
            chunk[i].Translate(Vector3.left * velocidad * Time.deltaTime, Space.World);

            if (chunk[i].position.x <= -7)
            {
                chunk[i].position = ultimoChunk.position + (Vector3.right * 7);
                ultimoChunk = chunk[i];
            }
        }
    }
}
