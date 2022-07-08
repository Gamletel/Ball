using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCubeController : MonoBehaviour
{
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Randomize()
    {
        animator.SetInteger("rnd", Random.Range(0,3));
    }
}
