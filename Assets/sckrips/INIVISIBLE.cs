//      _
//    _| |_
//   [__ __]
//     | |
//     |_|
//      _
//     ] [
//    [___]
//     | |
//     |_|
//    
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INIVISIBLE : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.GetComponent("Renderer") == true)
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
