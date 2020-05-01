using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]// permette di far apparire la variabile nell'inspector
    GameObject cubePrefab;
    // Start is called before the first frame update
    void Start() // funzione automatica che viene richiamata quando si preme play
    {
        Debug.Log("Sono spawnato", gameObject);
        // tra le virgolette c'è la frase che voglio far scrivere all'interno della console
        // facendo ,gameObject si fa il collegamento tra il log e l'oggetto che lo ha scritto
        // gameObject indica l'oggetto su cui questo componente è posizionato
        Debug.Log("Sono spawnato da " + gameObject.name);

        Instantiate(cubePrefab);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))// 0 click tasto sinistro, 1 click tasto destro
        {
            Instantiate(cubePrefab, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5)), cubePrefab.transform.rotation);
        }
    }
}