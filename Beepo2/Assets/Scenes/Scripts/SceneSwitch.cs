using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public string sceneName;
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Switch();
        }
    }
    void Switch()
    {
        SceneManager.LoadScene(sceneName);
    }
}
