using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name.Equals("Player"))
            GetMaterial().color = Color.red;
        if (gameObject.name.Equals("Platform"))
            GetMaterial().color = Color.green;
        //Debug.Log(GetComponents<Renderer>());
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(message: gameObject.tag);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.name.Equals("Player"))
            GetMaterial().color = Color.blue;

        if (gameObject.name.Equals("Platform"))
            GetMaterial().color = Color.black;

    }
    Material GetMaterial()
    {
        return GetComponent<Renderer>().material;
    }
}
