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
    public GameObject kaas;

    //ingredienten op tafel
    public GameObject t_tomaat;

    public GameObject t_pepperoni;
    public GameObject t_ui;
    public GameObject t_olijven;
    public GameObject t_paprika;
    public GameObject t_kaas;

    //ingredienten op besteloverzicht
    public GameObject b_tomaat;

    public GameObject b_pepperoni;
    public GameObject b_ui;
    public GameObject b_olijven;
    public GameObject b_paprika;
    public GameObject b_kaas;
    public GameObject menu;

    private void Start()
    {
        //ingredienten op pizza false
        tomaat.SetActive(false);
        pepperoni.SetActive(false);
        ui.SetActive(false);
        olijven.SetActive(false);
        paprika.SetActive(false);
        kaas.SetActive(false);
        //besteloverzicht false
        b_tomaat.SetActive(false);
        b_pepperoni.SetActive(false);
        b_ui.SetActive(false);
        b_olijven.SetActive(false);
        b_paprika.SetActive(false);
        b_kaas.SetActive(false);

        menu.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (other.gameObject.name == t_tomaat.name)
        {
            tomaat.SetActive(true);
            t_tomaat.SetActive(false);
            b_tomaat.SetActive(true);
        }
        if (other.gameObject.name == t_pepperoni.name)
        {
            pepperoni.SetActive(true);
            t_pepperoni.SetActive(false);
            b_pepperoni.SetActive(true);
        }
        if (other.gameObject.name == t_ui.name)
        {
            ui.SetActive(true);
            t_ui.SetActive(false);
            b_ui.SetActive(true);
        }
        if (other.gameObject.name == t_olijven.name)
        {
            olijven.SetActive(true);
            t_olijven.SetActive(false);
            b_olijven.SetActive(true);
        }
        if (other.gameObject.name == t_paprika.name)
        {
            paprika.SetActive(true);
            t_paprika.SetActive(false);
            b_paprika.SetActive(true);
        }
        if (other.gameObject.name == t_kaas.name)
        {
            kaas.SetActive(true);
            t_kaas.SetActive(false);
            b_kaas.SetActive(true);
        }
    }
}