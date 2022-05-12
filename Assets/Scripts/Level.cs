using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int level;
    [SerializeField] TMP_Text text;
    [SerializeField] GameObject overlay;
    // Start is called before the first frame update
    public int GetLevel()
    {
        return level;
    }

    public void IncreaseLevel()
    {
        level++;
        text.text = "Level " + level;
    }

    public void GameOver()
    {
        Destroy(gameObject);
        overlay.SetActive(true);
    }
}
