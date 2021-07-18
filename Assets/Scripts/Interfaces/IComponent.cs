using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IComponent
{
    public string componentType { get; set; }
    public int attachmentPriority { get; set; }


    /*
    * Note: Joints[0] should always be the joint where the component attaches to the joint of a component with a higher attachmentPriority (i.e. the base of the component).
    */
    public List<Transform> joints { get; set; }
}
