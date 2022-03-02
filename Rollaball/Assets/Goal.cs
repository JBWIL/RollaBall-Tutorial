using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject winTextObject;
    // Start is called before the first frame update
    void Start()
    {
         winTextObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        winTextObject.SetActive(true);
    }
}
