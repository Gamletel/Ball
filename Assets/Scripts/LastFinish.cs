using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastFinish : MonoBehaviour
{
    [SerializeField] private GameObject FinishCanvas;
    [SerializeField] private ParticleSystem FinishParticle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FinishCanvas.SetActive(true);
            FinishParticle.Play();
        }
    }
}
