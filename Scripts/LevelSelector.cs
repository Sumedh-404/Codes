using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelSelector : MonoBehaviour
{
    public int level;
    public TMP_Text leveltext;

    // Start is called before the first frame update
    void Start()
    {
        leveltext.text = level.ToString();
    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("level"+ level.ToString());
    }
}
