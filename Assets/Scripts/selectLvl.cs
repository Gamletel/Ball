using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectLvl : MonoBehaviour
{
    public int lvlIndex;

    public void StartLvl()
    {
        SceneManager.LoadScene(lvlIndex);
    }
}
