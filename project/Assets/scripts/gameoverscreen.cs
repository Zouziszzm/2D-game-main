﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameoverscreen : MonoBehaviour
{
    public Text PointsText;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        PointsText.text = " score:" + score.ToString(); 
    }
}
