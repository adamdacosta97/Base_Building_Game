using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildNode : MonoBehaviour
{
    public Color selectedColor;
    private Color startColor;
    private Renderer rend;
    public Vector3 positionOffset;

    private GameObject turret;
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }
    //change color when hovering over node
    void OnMouseEnter()
    {
        rend.material.color = selectedColor;
    }
    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
    //when selecting the node
    void OnMouseDown()
    {
        if(turret != null)
        {
            Debug.Log("Can't Bild ther");
            return;
        }
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }
}
