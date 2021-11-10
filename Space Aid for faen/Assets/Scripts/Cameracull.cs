using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Cameracull : MonoBehaviour
{

    public GameObject canvas;

    public CinemachineFreeLook aimCamera;

    void Update()
    {
        if (aimCamera.Priority == 20)
        {
            canvas.gameObject.SetActive(true);
        }
        else
        {
            canvas.gameObject.SetActive(false);
        }
    }
}