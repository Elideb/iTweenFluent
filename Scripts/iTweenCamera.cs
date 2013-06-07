//// Copyright (c) 2013 Enrique Juan Gil Izquierdo
//// 
//// Permission is hereby granted, free of charge, to any person obtaining a copy
//// of this software and associated documentation files (the "Software"), to deal
//// in the Software without restriction, including without limitation the rights
//// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//// copies of the Software, and to permit persons to whom the Software is
//// furnished to do so, subject to the following conditions:
//// 
//// The above copyright notice and this permission notice shall be included in
//// all copies or substantial portions of the Software.
//// 
//// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//// THE SOFTWARE.

using System.Collections.Generic;
using UnityEngine;

namespace iTweenFluent {

	/// <summary>
	/// Instantly changes the amount(transparency) of a camera fade
	/// and then returns it back over time.
	/// </summary>
	public class iTweenCameraFadeFrom : iTweenFluent {

		public static iTweenCameraFadeFrom Create() {
			return new iTweenCameraFadeFrom();
		}

		public iTweenCameraFadeFrom()
			: base( null ) {
		}

		public override void Launch() {
			iTween.CameraFadeFrom( new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For how transparent the Texture2D that the camera fade uses is.
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public iTweenCameraFadeFrom Amount(float amount) {
			return AddArgument<iTweenCameraFadeFrom>( "amount", amount );
		}

	}

	/// <summary>
	/// Changes the amount(transparency) of a camera fade over time.
	/// </summary>
	public class iTweenCameraFadeTo : iTweenFluent {

		public static iTweenCameraFadeTo Create() {
			return new iTweenCameraFadeTo();
		}

		public iTweenCameraFadeTo()
			: base( null ) {
		}

		public override void Launch() {
			iTween.CameraFadeTo( new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For how transparent the Texture2D that the camera fade uses is.
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public iTweenCameraFadeTo Amount(float amount) {
			return AddArgument<iTweenCameraFadeTo>( "amount", amount );
		}

	}

}
