using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{

    [SerializeField] Camera fpsCamera;
    [SerializeField] RigidbodyFirstPersonController fpsControl;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomOutSensitivity = 2f;
    [SerializeField] float zoomInSensitivity = 0.5f;

    

    bool zoomedInToggle = false;

    private void OnDisable()
    {
        ZoomOut();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle == false)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }
    }

    private void ZoomOut()
    {
        zoomedInToggle = false;
        fpsCamera.fieldOfView = zoomedOutFOV;
        fpsControl.mouseLook.XSensitivity = zoomOutSensitivity;
        fpsControl.mouseLook.YSensitivity = zoomOutSensitivity;
    }

    private void ZoomIn()
    {
        zoomedInToggle = true;
        fpsCamera.fieldOfView = zoomedInFOV;
        fpsControl.mouseLook.XSensitivity = zoomInSensitivity;
        fpsControl.mouseLook.YSensitivity = zoomInSensitivity;
    }
}
