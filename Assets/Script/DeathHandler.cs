using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathHandler : MonoBehaviour
{

    [SerializeField] Canvas gameoverCanvas;


    private void Start()
    {

        gameoverCanvas.enabled = false;

    }

    public void HandleDeath()
    {
        gameoverCanvas.enabled = true;
        Time.timeScale = 0;
        FindObjectOfType<WeaponSwitcher>().enabled = false;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }


}
