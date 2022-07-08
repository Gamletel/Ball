using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine("Elevate");
        }
    }
    IEnumerator Elevate()
    {
        animator.SetBool("isActive", true);
        yield return new WaitForSeconds(2.5f);
        animator.SetBool("isActive", false);
    }
}
