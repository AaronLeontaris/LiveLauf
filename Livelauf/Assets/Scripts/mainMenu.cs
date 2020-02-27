using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{

    public void LadeSimulation()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void VerlasseSimulation()
    {
        Debug.Log("Simulation wird verlassen.")
        Application.Quit();

    }

}
