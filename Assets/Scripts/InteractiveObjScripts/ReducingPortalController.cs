using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReducingPortalController : MonoBehaviour
{
    private bool canTransform = true;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (canTransform)
                Reducing(other);
            else
                UnReducing(other);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            canTransform = true;
    }
    #region Transforming
    private void Reducing(Collider col)
    {
        col.GetComponent<Transform>().localScale = col.GetComponent<Transform>().localScale / 2;
        canTransform = false;
    }
    private void UnReducing(Collider col)
    {
        col.GetComponent<Transform>().localScale = col.GetComponent<Transform>().localScale * 2;
        canTransform = false;
    }
    #endregion
}
