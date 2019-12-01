using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeUI : MonoBehaviour
{
    //controls where the node UI appears, whena node is selected
    private BuildNode target;
    public void SetTarget(BuildNode _target)
    {
        target = _target;
        transform.position = target.transform.position + target.GetBuildPosition();
    }
}
