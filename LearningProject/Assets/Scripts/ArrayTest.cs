using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    public GameObject[] objects;
    public Color[] colors;


    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        foreach(Color cor in colors){
            objects[i].GetComponent<Renderer>().material.color = cor;
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        int i = 0;
        foreach (GameObject obj in objects)
        {
            Destroy(obj, 2f + i);
            i += 2;
        }
    }
}
