using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pop_head : MonoBehaviour {

    public GameObject HeadToPop;
    public Material[] MaterialsToReplace;

	// Use this for initialization
	void Start () {
        PopHead(HeadToPop);
	}
	

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
