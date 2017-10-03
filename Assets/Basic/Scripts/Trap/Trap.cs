using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour {


    private Animator trapAnimator;

    // Use this for initialization
    void Start ()
    {
        trapAnimator = GetComponent<Animator>();

    }


    void OnTrapCatched()
    {
        trapAnimator.SetTrigger("OpenTrap");
    }

}
