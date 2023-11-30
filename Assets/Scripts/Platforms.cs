using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        Destroy(this.gameObject, 1);

        Debug.Log("Exit");
    }
}
