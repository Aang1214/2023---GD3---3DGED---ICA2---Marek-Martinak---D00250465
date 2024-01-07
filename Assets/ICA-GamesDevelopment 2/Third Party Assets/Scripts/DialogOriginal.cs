using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;
public class DialogOriginal : MonoBehaviour
{
   
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    public float typingSpeed;
 
    

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        
        textDisplay.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (textDisplay.text == sentences[index])
            {
                NextLine();
                
            }
            else
            {
                StopAllCoroutines();
                
                textDisplay.text = sentences[index];
            }
        }
    }

    void StartDialogue() { 
     index = 0;
        StartCoroutine(TypeLine());
    }

    

    IEnumerator TypeLine()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);

        }
    }

    void NextLine() 
    {
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        { 
         gameObject.SetActive(false);
        }
    }
}
