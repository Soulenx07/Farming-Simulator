using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public int sceneBuildIndex;
    public Vector2 playerPosition;
    public VectorValue playerStorage;

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger Entered");

        if(other.tag == "Player")
        {
            playerStorage.initialValue = playerPosition;
            print("Switching scene to " + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
}
