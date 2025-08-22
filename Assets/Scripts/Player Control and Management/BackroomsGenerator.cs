using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BackroomsGenerator : MonoBehaviour
{
    public Transform player;
    public GameObject backroomsPrefab;
    public List<string> values = new List<string>();
    float instantiateX;
    float instnatiateZ;
    public NavMeshSurface nvs;

    // Update is called once per frame
    void Update()
    {
        instantiateX = Mathf.Round((player.position.x + 50) / 50) * 50;
        instnatiateZ = Mathf.Round((player.position.z + 50) / 50) * 50;
        if(!values.Contains(instantiateX.ToString() + " " + instnatiateZ.ToString()))
        {
            Instantiate(backroomsPrefab, new Vector3(instantiateX, 0, instnatiateZ), Quaternion.Euler(0, UnityEngine.Random.Range(0, 3) * 90, 0), gameObject.transform);
            values.Add(instantiateX.ToString() + " " + instnatiateZ.ToString());
        }

        instantiateX = Mathf.Round((player.position.x) / 50) * 50;
        instnatiateZ = Mathf.Round((player.position.z + 50) / 50) * 50;
        if(!values.Contains(instantiateX.ToString() + " " + instnatiateZ.ToString()))
        {
            Instantiate(backroomsPrefab, new Vector3(instantiateX, 0, instnatiateZ), Quaternion.Euler(0, UnityEngine.Random.Range(0, 3) * 90, 0), gameObject.transform);
            values.Add(instantiateX.ToString() + " " + instnatiateZ.ToString());
        }

        instantiateX = Mathf.Round((player.position.x + 50) / 50) * 50;
        instnatiateZ = Mathf.Round((player.position.z) / 50) * 50;
        if(!values.Contains(instantiateX.ToString() + " " + instnatiateZ.ToString()))
        {
            Instantiate(backroomsPrefab, new Vector3(instantiateX, 0, instnatiateZ), Quaternion.Euler(0, UnityEngine.Random.Range(0, 3) * 90, 0), gameObject.transform);
            values.Add(instantiateX.ToString() + " " + instnatiateZ.ToString());
        }

        instantiateX = Mathf.Round((player.position.x - 50) / 50) * 50;
        instnatiateZ = Mathf.Round((player.position.z - 50) / 50) * 50;
        if(!values.Contains(instantiateX.ToString() + " " + instnatiateZ.ToString()))
        {
            Instantiate(backroomsPrefab, new Vector3(instantiateX, 0, instnatiateZ), Quaternion.Euler(0, UnityEngine.Random.Range(0, 3) * 90, 0), gameObject.transform);
            values.Add(instantiateX.ToString() + " " + instnatiateZ.ToString());
        }

        instantiateX = Mathf.Round((player.position.x) / 50) * 50;
        instnatiateZ = Mathf.Round((player.position.z - 50) / 50) * 50;
        if(!values.Contains(instantiateX.ToString() + " " + instnatiateZ.ToString()))
        {
            Instantiate(backroomsPrefab, new Vector3(instantiateX, 0, instnatiateZ), Quaternion.Euler(0, UnityEngine.Random.Range(0, 3) * 90, 0), gameObject.transform);
            values.Add(instantiateX.ToString() + " " + instnatiateZ.ToString());
        }

        instantiateX = Mathf.Round((player.position.x - 50) / 50) * 50;
        instnatiateZ = Mathf.Round((player.position.z) / 50) * 50;
        if(!values.Contains(instantiateX.ToString() + " " + instnatiateZ.ToString()))
        {
            Instantiate(backroomsPrefab, new Vector3(instantiateX, 0, instnatiateZ), Quaternion.Euler(0, UnityEngine.Random.Range(0, 3) * 90, 0), gameObject.transform);
            values.Add(instantiateX.ToString() + " " + instnatiateZ.ToString());
        }

        instantiateX = Mathf.Round((player.position.x - 50) / 50) * 50;
        instnatiateZ = Mathf.Round((player.position.z + 50) / 50) * 50;
        if(!values.Contains(instantiateX.ToString() + " " + instnatiateZ.ToString()))
        {
            Instantiate(backroomsPrefab, new Vector3(instantiateX, 0, instnatiateZ), Quaternion.Euler(0, UnityEngine.Random.Range(0, 3) * 90, 0), gameObject.transform);
            values.Add(instantiateX.ToString() + " " + instnatiateZ.ToString());
        }

        instantiateX = Mathf.Round((player.position.x + 50) / 50) * 50;
        instnatiateZ = Mathf.Round((player.position.z - 50) / 50) * 50;
        if(!values.Contains(instantiateX.ToString() + " " + instnatiateZ.ToString()))
        {
            Instantiate(backroomsPrefab, new Vector3(instantiateX, 0, instnatiateZ), Quaternion.Euler(0, UnityEngine.Random.Range(0, 3) * 90, 0), gameObject.transform);
            values.Add(instantiateX.ToString() + " " + instnatiateZ.ToString());
        }

        // nvs.BuildNavMesh();
    }
}
