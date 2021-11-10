using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CarrotHandler : MonoBehaviour
{
    public Vector3[] positions = new Vector3[0];
    public bool[] shouldFlip = new bool[0];

    private int currentIndex;
    private RectTransform rectTransform;
    private MenuController controller;
    private TMP_Text text;
    private bool flipped = false;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponentInParent<MenuController>();
        text = GetComponent<TMP_Text>();
        rectTransform = GetComponent<RectTransform>();

        Process();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentIndex != controller.currentIndex)
        {
            Process();
        }
    }

    void Process()
    {
        currentIndex = controller.currentIndex;
        if (shouldFlip[currentIndex])
        {
            text.text = "<";
            text.alignment = TextAlignmentOptions.MidlineRight;
        }
        else
        {
            text.text = ">";
            text.alignment = TextAlignmentOptions.MidlineLeft;
        }
        rectTransform.anchoredPosition = positions[currentIndex];
    }
}
