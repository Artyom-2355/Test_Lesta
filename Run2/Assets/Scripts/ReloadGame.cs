using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReloadGame : MonoBehaviour
{
    public void ReloadLevel()
    {
        SceneManager.LoadScene(2);
    }
}
