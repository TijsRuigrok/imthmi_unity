using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListManager : MonoBehaviour
{
    [SerializeField] private ListItem listItem;
    [SerializeField] private GameObject list;
    [SerializeField] private RectTransform rt;

    public void CreateNewListItem(string itemName)
    {
        ListItem newListItem = Instantiate(listItem);
        newListItem.UpdateNameText(itemName);
        newListItem.transform.SetParent(list.transform);
        newListItem.transform.position = new Vector3(0,0,0);
        LayoutRebuilder.ForceRebuildLayoutImmediate(rt);
    }

    private void Start()
    {
        CreateNewListItem("tomaat");
    }
}


