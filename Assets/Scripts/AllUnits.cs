using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllUnits : MonoBehaviour {

    public GameObject[] units;
    public GameObject unitPrefab;
    public int numUnits = 10;
    public Vector3 range = new Vector3(5, 5, 5);

    public Toggle t_Objectif;
    public Toggle t_Obeissant;
    public Toggle t_Tetu;

    public bool chercherObjectif;
    public bool obeissant;
    public bool tetu;

    [Range(0, 200)]
    public int neighbourDistance = 50;

    [Range(0, 2)]
    public float maxforce = 0.5f;

    [Range(0, 5)]
    public float maxvelocity = 2.0f;



    // Use this for initialization
    void Start() {

        if (t_Objectif.isOn) {

            chercherObjectif = true;
        }
        else {
            chercherObjectif = false;
        }

        if (t_Obeissant.isOn) {

            chercherObjectif = true;
        }
        else {
            obeissant = false;
        }

        if (t_Tetu.isOn) {

            tetu = true;
        }
        else {
            tetu = false;
        }



        units = new GameObject[numUnits];

        for (int i = 0; i < numUnits; i++) {
            Vector3 unitPos = new Vector3(Random.Range(-range.x, range.x), Random.Range(-range.y, range.y), Random.Range(0, 0));

            units[i] = Instantiate(unitPrefab, this.transform.position + unitPos, Quaternion.identity) as GameObject;
            units[i].GetComponent<Unit>().manager = this.gameObject;
        }


    }

    // Update is called once per frame
    void Update() {
        if (t_Objectif.isOn) {

            chercherObjectif = true;
        }
        else {
            chercherObjectif = false;
        }

        if (t_Obeissant.isOn) {

            chercherObjectif = true;
        }
        else {
            obeissant = false;
        }

        if (t_Tetu.isOn) {

            tetu = true;
        }
        else {
            tetu = false;
        }
    }

    private void OnDrawGizmosSelected() {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(this.transform.position, range * 2);
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(this.transform.position, 0.2f);
    }
}
