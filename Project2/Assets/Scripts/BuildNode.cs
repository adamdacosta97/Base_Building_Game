using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildNode : MonoBehaviour
{
    public Color selectedColor;
    private Color startColor;
    private Renderer rend;
    public Vector3 positionOffset;
    BuildManager buildManager;

    public GameObject turret;
    //get build amanger, rendereer and color
    void Start()
    {
        buildManager = BuildManager.instance;
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
    //when selecting the node find a turret to build
    void OnMouseDown()
    {
        if(!buildManager.CanBuild)
        {
            return;
        }
        if(turret != null)
        {
            return;
        }
        buildManager.BuildTurretOn(this);
    }
    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }
}
