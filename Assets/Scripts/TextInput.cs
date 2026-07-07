using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextInput : MonoBehaviour
{
    [SerializeField] private AnimationManager animator;
    [SerializeField] private TMP_InputField input;
    [SerializeField] private List<TextMeshProUGUI> inputText;
    [SerializeField] private List<TextMeshProUGUI> clearText;
    [SerializeField] private List<TextMeshProUGUI> dummyText;
    private int clearCount = 0;
    private int clickCount = 0;
    [HideInInspector] public bool isClear = false;
    void Start()
    {
        input.text = "";
        for(int i = 0; i < inputText.Count; i++)
        {
            inputText[i].enabled = false;
        }
        for(int i = 0; i < dummyText.Count; i++)
        {
            dummyText[i].enabled = false;
        }
        for(int i = 0; i < clearText.Count; i++)
        {
            clearText[i].enabled = false;
        }
        inputText[clickCount].enabled = true;
    }


    public void IsTextClick()
    {
        animator.TextMoveDummy();
        clickCount++;
        if (clickCount == 5)
        {
            clearText[clearCount].enabled = true;
            dummyText[clearCount].enabled = false;
            isClear = true;
            clickCount = 0;
        }
    }

    public void TextCheck()
    {
        if (input.text == "‚¢‚­‚ç")
        {
            clearCount = TextClear(clearCount);
        }
    }


    private int TextClear(int count)
    {
        if (count == 0) isClear = true;
        if (!isClear) return count;

        inputText[count].enabled = false;
        dummyText[count].enabled = false;
        count++;
        NextText(count);
        return count;
    }

    private void NextText(int count)
    {
        isClear = false;
        dummyText[count].enabled = true;
        inputText[count].enabled = true;
        input.text = "";
    }
}
