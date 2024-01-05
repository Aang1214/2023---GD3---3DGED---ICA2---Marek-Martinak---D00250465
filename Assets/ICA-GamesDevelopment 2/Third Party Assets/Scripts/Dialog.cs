using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialog : MonoBehaviour
{
    public GameObject dialogBox;
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    public float typingSpeed;
    public Cinemachine.CinemachineVirtualCamera playercam;
    

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        dialogBox.SetActive(false);
        textDisplay.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dialogBox.SetActive(true);
            playercam.Priority = 9;
        }
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
            dialogBox.SetActive(false);
            playercam.Priority = 16;
            //gameObject.SetActive(false);
        }
    }
}
