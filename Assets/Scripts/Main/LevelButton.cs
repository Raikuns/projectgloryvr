using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButton : MonoBehaviour
{
    public Level level;

    public void OnPressed()
    {
        LevelManager.instance.SelectLevel(level);
    }
}