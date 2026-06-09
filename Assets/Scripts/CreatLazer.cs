using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreatLazer : MonoBehaviour
{
    [SerializeField] GameObject laserPrefub;

    private void OnLaswer()
    {
        GameObject laswer = Instantiate(laserPrefub, this.gameObject.transform.position, Quaternion.identity);
        laswer.GetComponent<PointerTarget>();
    }
}
