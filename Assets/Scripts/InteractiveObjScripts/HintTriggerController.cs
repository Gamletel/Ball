using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HintTriggerController : MonoBehaviour
{
    [SerializeField] private GlobalHint hint;
    [SerializeField] private string hintStr;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hint.hintAnimator.SetBool("openHint", true);
            hint.hintTxt.text = hintStr;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hint.hintAnimator.SetBool("openHint", false);
        }
    }
}