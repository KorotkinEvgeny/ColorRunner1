using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            SendMessageUpwards("OnTrapCatched");
            Debug.Log("PLayer trapped");
        }
    }

}
