using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR 
using Unity.EditorCoroutines.Editor;


[ExecuteInEditMode]
public class DuplicateCatcher : MonoBehaviour
{
    [SerializeField] int instanceID = 0;

    public Material[] balloonMaterials;
    void Awake()
    {
        if (Application.isPlaying)
            return;

            if (instanceID != GetInstanceID())
        {
            if (instanceID == 0)
            {
                instanceID = GetInstanceID();
            }
            else
            {
                instanceID = GetInstanceID();
                if (instanceID < 0)
                {
                    StartCoroutine(RandomiseBalloon());
                }
            }
        }
    }

    IEnumerator RandomiseBalloon()
    {       
        yield return new EditorWaitForSeconds(1.0f);

        GetComponent<AudioSource>().pitch = Random.Range(0.5f, 1.5f);

        var rand = Random.Range(0.55f, 0.65f);

        transform.localScale = new Vector3(rand, rand, rand);

        int mat = Random.Range(0, balloonMaterials.Length);

        GetComponent<MeshRenderer>().material = balloonMaterials[mat];



    }
}
#endif