using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pop_head : MonoBehaviour {

    public GameObject HeadToPop;
    public Material[] MaterialsToReplace;

    private void OnTriggerEnter(Collider other)
    {
        PopHead(HeadToPop);
    }

    // Use this for initialization
    private void PopHead(GameObject head){
        var skinnedRenderer = head.GetComponent<SkinnedMeshRenderer>();
        if(skinnedRenderer != null){
            skinnedRenderer.enabled = false;
        }
        head.AddComponent<MeshRenderer>();
        MeshRenderer meshRenderer = head.GetComponent<MeshRenderer>();
        meshRenderer.materials = MaterialsToReplace;
        head.AddComponent<Rigidbody>();
        //head.GetComponent<Rigidbody>().velocity = (new Vector3(1,2,0));
        head.AddComponent<SphereCollider>();
    }
}
