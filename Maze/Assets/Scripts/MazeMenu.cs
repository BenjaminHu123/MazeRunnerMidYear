using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeMenu : MonoBehaviour {

    public void ReturnToMainMenu()
    {
        SceneManager.GetSceneAt(0);
    }
}
