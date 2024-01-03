using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectCounter : MonoBehaviour
{
    public static CollectCounter instance;
    public TMP_Text coinText;
    public int currentCoins = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        coinText.text = ": " + currentCoins.ToString();
    }

    public void IncreaseCoins(int v)
    {
        currentCoins += v;
        coinText.text = ": " + currentCoins.ToString();
    }
}
