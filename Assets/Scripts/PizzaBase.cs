using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaBase : MonoBehaviour
{
    [SerializeField] private GameObject model;
    [SerializeField] private GameObject menu;
    [SerializeField] private Vector3 offset;
    
    void Start()
    {
        MediumState();
    }

    private void Update()
    {
        menu.transform.position = model.transform.position + offset;
    }

    public void MediumState()
    {
        model.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
    }

    public void ItalianState()
    {
        model.transform.localScale = new Vector3(0.29f, 0.20f, 0.20f);
    }

    public void LargeState()
    {
        model.transform.localScale = new Vector3(0.35f, 0.25f, 0.25f);
    }
}
