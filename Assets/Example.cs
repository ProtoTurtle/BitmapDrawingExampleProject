using UnityEngine;
using System.Collections;

using ProtoTurtle.BitmapDrawing;


public class Example : MonoBehaviour {

	
	void Start () {

        Material material = renderer.material;
        Texture2D texture = new Texture2D(512,512, TextureFormat.RGB24, false);
        texture.wrapMode = TextureWrapMode.Clamp;
        material.SetTexture(0, texture);

        texture.DrawFilledRectangle(new Rect(0, 0, 120, 120), Color.green);

        texture.DrawRectangle(new Rect(0, 0, 120, 60), Color.red);

        texture.DrawCircle(256, 256, 100, Color.cyan);
        texture.DrawFilledCircle(256, 256, 50, Color.grey);

        texture.DrawCircle(0, 0, 512, Color.red);

        texture.DrawLine(new Vector2(120, 60), new Vector2(256, 256), Color.black);
        


        texture.Apply();
        
        

	}
	
}
