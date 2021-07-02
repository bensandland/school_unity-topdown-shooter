using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int nextLevelNum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PointScript.instance.GetTotal() >= 100)
        {
            LoadNextLevel();
        }
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene(nextLevelNum);
    }
}
