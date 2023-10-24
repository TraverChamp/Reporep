using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnter : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider other)
    {
        Debug.Log(message: "OncollisionEnter2D");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(message: "OncollisionExit2D");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(message: "OncollisionStay2D");
    }
}
