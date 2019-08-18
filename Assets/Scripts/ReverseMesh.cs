using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ReverseMesh : MonoBehaviour
{
    public bool removeExistingColliders = true;
    // Start is called before the first frame update
    void Start()
    {
        CreateInvertedMeshCollider();
    }

    void CreateInvertedMeshCollider()
    {
        if (removeExistingColliders) RemoveExistingCollider();

        InvertMesh();
        gameObject.AddComponent<MeshCollider>();
    }

    void RemoveExistingCollider()
    {
        Collider[] colliders = GetComponents<Collider>();
        for (int i=0; i < colliders.Length; i++)
        {
            DestroyImmediate(colliders[i]);
        }
    }

    void InvertMesh()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.triangles = mesh.triangles.Reverse().ToArray();
    }
}
