using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyForDoor : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] ParticleSystem pickupParticle;
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine("DelayBeforeDestroy");
        animator.SetTrigger("Open");
    }
    public void DestroyDoor()
    {
        Destroy(gameObject);
    }
    private IEnumerator DelayBeforeDestroy()
    {
        pickupParticle.Play();
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

}
