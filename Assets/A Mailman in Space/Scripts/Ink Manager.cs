using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using UnityEngine.EventSystems;
using TMPro;

public class InkManager : MonoBehaviour, IPointerClickHandler
{

    [Header("Ink JSON")]
   [SerializeField] private TextAsset inkJSON;

    public TextMeshProUGUI textBox;

    private Story currentStory;
    private Story story;


    private void Awake()
    {

        story = new Story(inkJSON.text);
    }

    private void Update()
    {
        if (story.canContinue)
        {
            string newLine = story.Continue();
            List<string> tags = story.currentTags;

            if (tags.Count > 0 && tags[0] == "choice")

            {
                Debug.Log("We saw the choice");
                newLine = "<u>" + "<link = \"crog\">" + newLine + " </link>" + "</u>";
                Debug.Log(newLine);

            }

            textBox.text += newLine;
        }
    }

    public void openLetter(TextAsset inkJSON)
    {

    }


    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("clicking works");
       TMP_Text pTextMeshPro = GetComponent<TMP_Text>();

        Vector3 mousePos = new Vector3(eventData.position.x, eventData.position.y, 0);

        int linkIndex = TMP_TextUtilities.FindIntersectingLink(textBox, Input.mousePosition, null);

        if (linkIndex != -1)
        {
            Debug.Log(linkIndex);
        
            TMP_LinkInfo linkInfo = textBox.textInfo.linkInfo[linkIndex];
            //Debug.Log(linkInfo.GetLinkText());
            Debug.Log(linkInfo.GetLinkID());
            if (linkInfo.GetLinkID() == "")
            {
                Debug.Log("holy moly it worked!!!");
            }
            else
            {
               Debug.Log("It did not work...");
            }
           
        }
    }

}
