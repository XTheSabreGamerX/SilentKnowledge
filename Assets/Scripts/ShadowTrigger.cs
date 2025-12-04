using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowTrigger : MonoBehaviour
{
    public Shadow shadow;
    public AudioSource Jumpscare;

    private bool done = false;

    void OnTriggerEnter(Collider other)
    {
        if (!done && other.CompareTag("Player"))
        {
            shadow.TriggerShadow();
            done = true;
        }

        if (Jumpscare != null)
        {
            Jumpscare.Play();
        }
    }
}