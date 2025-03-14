using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using UnityEngine.EventSystems;

public class InkManager : MonoBehaviour, IPointerClickHandler
{

    [Header("Ink JSON")]
   [SerializeField] private TextAsset inkJSON;

    private void Awake()
    {
    
    }
    public void OnPointerClick(PointerEventData eventData)
    {

    }

}
