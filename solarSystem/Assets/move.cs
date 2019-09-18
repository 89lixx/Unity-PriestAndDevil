using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Texture2D img;
	public Transform sun;
    public Transform waterplanet;
    public Transform earth;
    //public Transform moon;
    public Transform goldplanet;
    public Transform mars;
    public Transform woodplanet;
    public Transform mudplanet;
    public Transform tianwang;
    public Transform haiwang;
    // Start is called before the first frame update
    private void OnGUI()
    {
        //GUIStyle bg = new GUIStyle();
        //bg.normal.background = img;
        //GUI.Label(new Rect(0, 0, 1024, 781), "", bg);
    }
    // Update is called once per frame
    void Update()
    {
        sun.Rotate(Vector3.up * 3 * Time.deltaTime);
        waterplanet.RotateAround(sun.position, new Vector3(0,1,1), 200 * Time.deltaTime);
        goldplanet.RotateAround(sun.position, new Vector3(0, 2, 1), 100 * Time.deltaTime);
        earth.RotateAround(sun.position, Vector3.up, 50 * Time.deltaTime);
        //moon.RotateAround(earth.position, new Vector3(0,0.1f,0.1f), 100 * Time.deltaTime);
        mars.RotateAround(sun.position, new Vector3(0, 2, 2), 40 * Time.deltaTime);
        woodplanet.RotateAround(sun.position, new Vector3(0, 1, 2), 30 * Time.deltaTime);
        mudplanet.RotateAround(sun.position, new Vector3(0, 3, 2), 20 * Time.deltaTime);
        tianwang.RotateAround(sun.position, new Vector3(0, 3, 1), 10 * Time.deltaTime);
        haiwang.RotateAround(sun.position, new Vector3(0, 2, 4), 5 * Time.deltaTime);
    }
}
