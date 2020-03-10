using System.Collections.Generic;
using UnityEngine;

public class GravitySimul : MonoBehaviour
{
    //This needs improvement for when it will be used with a large amount of objects.


    const float G = 6.674f;
    public Rigidbody rb;
    public static List<GravitySimul> lsitofOjbects;

    private void FixedUpdate()
    {
        foreach(GravitySimul gs in lsitofOjbects)
        {
            if(gs != this)
            Attract(gs);
        }
    }

    private void OnEnable()
    {
        if (lsitofOjbects == null)
            lsitofOjbects = new List<GravitySimul>();

        lsitofOjbects.Add(this);
    }

    private void OnDisable()
    {
        lsitofOjbects.Remove(this);
    }
    void Attract(GravitySimul toAttract)
    {
        Rigidbody rbToattrach = toAttract.rb;

        Vector3 direction = rb.position - rbToattrach.position;
        float distance = direction.magnitude;

        if (distance == 0)
            return;

        float forceMagnitude = G * (rb.mass * rbToattrach.mass) / Mathf.Pow(distance, 2);

        Vector3 force = direction.normalized * forceMagnitude;

        rbToattrach.AddForce(force);
    }
}
