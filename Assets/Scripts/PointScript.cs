using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointScript : MonoBehaviour
{
    public GameObject pointCanvas;
    public static PointScript instance;

    public Text pointUI;

    private int totalPoints;

    private void Awake()
    {
        DontDestroyOnLoad(pointCanvas);
        instance = this;
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        pointUI.text = "Points: " + totalPoints.ToString();
    }

    public void AddPoints(int points)
    {
        totalPoints += points;
        pointUI.text = "Points: " + totalPoints.ToString();
    }

    public int GetTotal()
    {
        return totalPoints;
    }
}
