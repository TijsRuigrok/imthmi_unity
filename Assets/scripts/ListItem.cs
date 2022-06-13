using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ListItem : MonoBehaviour
{
    [SerializeField] private TMP_Text itemText;
    
    public void UpdateNameText(string name)
    {
        itemText.text = name;
    }
}
