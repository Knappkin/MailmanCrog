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
            textBox.text = story.Continue();
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
       
    }

}
