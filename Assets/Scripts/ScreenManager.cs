using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{

    // Update is called once per frame
   public void loadScene()
    {
        SceneManager.LoadScene(tag);
    }
}
