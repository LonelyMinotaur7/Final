using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diamond : MonoBehaviour
{
    public static int score;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);

        score = score + 1;

        Debug.Log(score);
    }

    public Text ValueText;
    private void Start()
    {
        ValueText.text = score.ToString();
    }

    private void Update()
    {
        ValueText.text = score.ToString();
    }
}
