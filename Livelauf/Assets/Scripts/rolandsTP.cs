using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rolandsTP : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePLayer;

    private void OnTriggerEnter(Collider other)
    {
        thePLayer.transform.position = teleportTarget.transform.position;
    }
}
