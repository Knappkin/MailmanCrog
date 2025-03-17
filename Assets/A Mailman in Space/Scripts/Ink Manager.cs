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
    private Story story;

    

    private void Awake()
    {

        story = new Story(inkJSON.text);
    }

    private void Update()
    {
        if (story.canContinue)
        {
            List<string> tags = story.currentTags;

            if (tags.Count > 0 && tags[0] == "choice")

            {
                Debug.Log("We saw the choice");

            }
       
            textBox.text += story.Continue();
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
       
    }

}
