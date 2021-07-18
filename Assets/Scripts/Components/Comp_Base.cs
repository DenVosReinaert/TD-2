using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comp_Base : MonoBehaviour, IComponent
{
    #region IComponent interface requirements
    public string componentType { get; set; }
    public int attachmentPriority { get; set; }

    public List<Transform> joints { get; set; }
    #endregion

    public string componentType_;
    public int attachmentPriority_;

    public List<Transform> joints_;

    void Awake()
    {
        componentType = componentType_;
        attachmentPriority = attachmentPriority_;
        joints = joints_;

        Debug.Log(componentType + ", " + attachmentPriority + ", " + joints[0].name);
    }

    void Update()
    {
        
    }
}
