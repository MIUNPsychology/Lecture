using UnityEngine;
using System.Collections;

public class AnimateFace : MonoBehaviour {

	private float morph = 0.0f;

	public SkinnedMeshRenderer body;
	public SkinnedMeshRenderer eyebrows;
	public SkinnedMeshRenderer eyelashes;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("changeMorph", 2.0f, 0.02f);
	}
	
	void changeMorph() {

		if (morph >= 99.0f) {
			CancelInvoke ("changeMorph");
		}

		morph = morph + 1.0f;

		if (body != null) {
			body.SetBlendShapeWeight (0, morph);
			body.SetBlendShapeWeight (1, morph);
			body.SetBlendShapeWeight (6, morph);
			body.SetBlendShapeWeight (7, morph);
			body.SetBlendShapeWeight (8, morph);
			body.SetBlendShapeWeight (13, morph / 2);
			body.SetBlendShapeWeight (14, morph / 2);
			body.SetBlendShapeWeight (30, morph);
			body.SetBlendShapeWeight (31, morph);
			body.SetBlendShapeWeight (45, morph);
		}

		if (eyebrows != null) {
			eyebrows.SetBlendShapeWeight (0, morph);
			eyebrows.SetBlendShapeWeight (1, morph);
			eyebrows.SetBlendShapeWeight (6, morph);
			eyebrows.SetBlendShapeWeight (7, morph);
			eyebrows.SetBlendShapeWeight (8, morph);
			eyebrows.SetBlendShapeWeight (13, morph);
		}

		if (eyelashes != null) 
		{
			eyelashes.SetBlendShapeWeight (0, morph);
		}
	}
}
