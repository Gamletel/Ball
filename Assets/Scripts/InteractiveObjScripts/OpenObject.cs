using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenObject : MonoBehaviour
{
    [SerializeField] private GameObject visibleObj;
    [SerializeField] private GameObject invisibleObj;
    private bool reverse = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            reverse = !reverse;
            switch (reverse)
            {
                case true:
                    visibleObj.SetActive(true);
                    invisibleObj.SetActive(false);
                    return;
                case false:
                    visibleObj.SetActive(false);
                    invisibleObj.SetActive(true);
                    return;
            }
            
        }
    }
}
