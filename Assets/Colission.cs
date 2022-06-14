using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colission : MonoBehaviour
{
    //ingredienten op pizza
    public GameObject tomaat;

    public GameObject pepperoni;
    public GameObject ui;
    public GameObject olijven;
    public GameObject paprika;

    //ingredienten op tafel
    public GameObject t_tomaat;

    public GameObject t_pepperoni;
    public GameObject t_ui;
    public GameObject t_olijven;
    public GameObject t_paprika;

    private void Start()
    {
        tomaat.SetActive(false);
        pepperoni.SetActive(false);
        ui.SetActive(false);
        olijven.SetActive(false);
        paprika.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (other.gameObject.name == t_tomaat.name)
        {
            tomaat.SetActive(true);
            t_tomaat.SetActive(false);
        }
        if (other.gameObject.name == t_pepperoni.name)
        {
            pepperoni.SetActive(true);
            t_pepperoni.SetActive(false);
        }
        if (other.gameObject.name == t_ui.name)
        {
            ui.SetActive(true);
            t_ui.SetActive(false);
        }
        if (other.gameObject.name == t_olijven.name)
        {
            olijven.SetActive(true);
            t_olijven.SetActive(false);
        }
        if (other.gameObject.name == t_paprika.name)
        {
            paprika.SetActive(true);
            t_paprika.SetActive(false);
        }
    }
}