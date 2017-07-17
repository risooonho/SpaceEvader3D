using UnityEngine;
using System.Collections;

public class MineMaterialSelectorScript : MonoBehaviour {

	public static string BOX1_MAT = "Materials/MineMat1";
	public static string BOX2_MAT = "Materials/MineMat2";
	public static string BOX3_MAT = "Materials/MineMat3";
	public static string BOX4_MAT = "Materials/MineMat4";
	public static string BOX5_MAT = "Materials/MineMat5";
	public static string BOX6_MAT = "Materials/MineMat6";
	public static string BOX7_MAT = "Materials/MineMat7";
	
	public enum BoxMaterials
	{
		Box1,
		Box2,
		Box3,
		Box4,
		Box5,
		Box6,
		Box7
	}
	
	// TODO: figure out which materials we want to use depending on the level (the
	// sky box is really what determines this)
	void Start () 
	{
		int materialId = Random.Range(0,10000) % System.Enum.GetValues(typeof(BoxMaterials)).Length;
		
		Material newMat;
		if ( materialId == (int)BoxMaterials.Box1 )
			newMat = Resources.Load(BOX1_MAT, typeof(Material)) as Material;
		else if ( materialId == (int)BoxMaterials.Box2 )
			newMat = Resources.Load(BOX2_MAT, typeof(Material)) as Material;
		else if ( materialId == (int)BoxMaterials.Box3 )
			newMat = Resources.Load(BOX3_MAT, typeof(Material)) as Material;
		else if ( materialId == (int)BoxMaterials.Box4 )
			newMat = Resources.Load(BOX4_MAT, typeof(Material)) as Material;
		else if ( materialId == (int)BoxMaterials.Box5 )
			newMat = Resources.Load(BOX5_MAT, typeof(Material)) as Material;
		else if ( materialId == (int)BoxMaterials.Box6 )
			newMat = Resources.Load(BOX6_MAT, typeof(Material)) as Material;
		else 
			newMat = Resources.Load(BOX7_MAT, typeof(Material)) as Material;
		
		int numChildren = this.transform.childCount;
		if ( numChildren > 1 )
		{
			// going with the assumption that the children don't have children
			for ( int i = 0; i < numChildren; i++ ) 
			{
				this.transform.GetChild(i).GetComponent<Renderer>().material = newMat;
			}
		}
		else
			this.GetComponent<Renderer>().material = newMat;
	}
}
