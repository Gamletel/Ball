using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporting : MonoBehaviour
{
    [SerializeField] private TeleportHelper helper;
    [SerializeField] private Transform teleportTo;
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && helper.canTeleport == true)
        {
            other.gameObject.transform.position = teleportTo.position;
            StartCoroutine("Cooldown");
        }
    }
    IEnumerator Cooldown()
    {
        helper.canTeleport = false;
        animator.SetBool("isActivated", true);
        yield return new WaitForSeconds(1);
        animator.SetBool("isActivated", false);
        helper.canTeleport = true;
        
    }
}
