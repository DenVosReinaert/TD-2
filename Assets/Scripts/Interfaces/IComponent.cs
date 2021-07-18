using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IComponent
{
    public string componentType { get; set; }
    public int attachmentPriority { get; set; }

    public List<Transform> joints { get; set; }
}
