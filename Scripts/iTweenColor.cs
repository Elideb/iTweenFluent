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
	/// Changes a GameObject's color values instantly then returns them to the
	/// provided properties over time.
	/// If a Light, GUIText or GUITexture component is attached,
	/// it will become the target of the animation.
	/// </summary>
	public class iTweenColorFrom : iTweenFluent {

		public static iTweenColorFrom Create(GameObject target) {
			return new iTweenColorFrom( target );
		}
		
		public iTweenColorFrom(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.ColorFrom( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// The color to fade the object to.
		/// </summary>
		/// <param name="color"></param>
		/// <returns></returns>
		public iTweenColorFrom Color(Color color) {
			return AddArgument<iTweenColorFrom>( "color", color );
		}

		/// <summary>
		/// For the individual setting of the color red.
		/// </summary>
		/// <param name="r"></param>
		/// <returns></returns>
		public iTweenColorFrom R(float r) {
			return AddArgument<iTweenColorFrom>( "r", r );
		}

		/// <summary>
		/// For the individual setting of the color green.
		/// </summary>
		/// <param name="g"></param>
		/// <returns></returns>
		public iTweenColorFrom G(float g) {
			return AddArgument<iTweenColorFrom>( "g", g );
		}

		/// <summary>
		/// For the individual setting of the color blue.
		/// </summary>
		/// <param name="b"></param>
		/// <returns></returns>
		public iTweenColorFrom B(float b) {
			return AddArgument<iTweenColorFrom>( "b", b );
		}

		/// <summary>
		/// For the individual setting of the alpha.
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
		public iTweenColorFrom A(float a) {
			return AddArgument<iTweenColorFrom>( "a", a );
		}

		/// <summary>
		/// For which color of a shader to use. Uses "_Color" by default.
		/// </summary>
		/// <param name="namedColorValue"></param>
		/// <returns></returns>
		public iTweenColorFrom NamedColorValue(string namedColorValue) {
			return AddArgument<iTweenColorFrom>( "NamedColorValue", namedColorValue );
		}

		/// <summary>
		/// for whether or not to include children of this GameObject.
		/// True by default.
		/// </summary>
		/// <param name="includeChildren"></param>
		/// <returns></returns>
		public iTweenColorFrom IncludeChildren(bool includeChildren) {
			return AddArgument<iTweenColorFrom>( "includechildren", includeChildren );
		}
	}

	/// <summary>
	/// Changes a GameObject's color values over time.
	/// If a Light, GUIText or GUITexture component is attached,
	/// they will become the target of the animation.
	/// </summary>
	public class iTweenColorTo : iTweenFluent {

		public static iTweenColorTo Create(GameObject target) {
			return new iTweenColorTo( target );
		}

		public iTweenColorTo(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.ColorTo( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// The color to fade the object to.
		/// </summary>
		/// <param name="color"></param>
		/// <returns></returns>
		public iTweenColorTo Color(Color color) {
			return AddArgument<iTweenColorTo>( "color", color );
		}

		/// <summary>
		/// For the individual setting of the color red.
		/// </summary>
		/// <param name="r"></param>
		/// <returns></returns>
		public iTweenColorTo R(float r) {
			return AddArgument<iTweenColorTo>( "r", r );
		}

		/// <summary>
		/// For the individual setting of the color green.
		/// </summary>
		/// <param name="g"></param>
		/// <returns></returns>
		public iTweenColorTo G(float g) {
			return AddArgument<iTweenColorTo>( "g", g );
		}

		/// <summary>
		/// For the individual setting of the color blue.
		/// </summary>
		/// <param name="b"></param>
		/// <returns></returns>
		public iTweenColorTo B(float b) {
			return AddArgument<iTweenColorTo>( "b", b );
		}

		/// <summary>
		/// For the individual setting of the alpha.
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
		public iTweenColorTo A(float a) {
			return AddArgument<iTweenColorTo>( "a", a );
		}

		/// <summary>
		/// For which color of a shader to use. Uses "_Color" by default.
		/// </summary>
		/// <param name="namedColorValue"></param>
		/// <returns></returns>
		public iTweenColorTo NamedColorValue(string namedColorValue) {
			return AddArgument<iTweenColorTo>( "NamedColorValue", namedColorValue );
		}

		/// <summary>
		/// For whether or not to include children of this GameObject.
		/// True by default.
		/// </summary>
		/// <param name="includeChildren"></param>
		/// <returns></returns>
		public iTweenColorTo IncludeChildren(bool includeChildren) {
			return AddArgument<iTweenColorTo>( "includechildren", includeChildren );
		}
	}

	/// <summary>
	/// Similar to ColorTo but incredibly less expensive for usage inside the
	/// Update function or similar looping situations involving a "live" set of
	/// changing values. Does not utilize an EaseType.
	/// </summary>
	public class iTweenColorUpdate {
		private GameObject target;

		private Dictionary<string, object> arguments = new Dictionary<string, object>();

		public static iTweenColorUpdate Create(GameObject target) {
			return new iTweenColorUpdate( target );
		}

		public iTweenColorUpdate(GameObject target) {
			this.target = target;
		}

		public void Launch() {
			iTween.ColorUpdate( target, new System.Collections.Hashtable( arguments ) );
		}

		/// <summary>
		/// The color to fade the object to.
		/// </summary>
		/// <param name="color"></param>
		/// <returns></returns>
		public iTweenColorUpdate Color(Color color) {
			return AddArgument( "color", color );
		}

		/// <summary>
		/// For the individual setting of the color red.
		/// </summary>
		/// <param name="r"></param>
		/// <returns></returns>
		public iTweenColorUpdate R(float r) {
			return AddArgument( "r", r );
		}

		/// <summary>
		/// For the individual setting of the color green.
		/// </summary>
		/// <param name="g"></param>
		/// <returns></returns>
		public iTweenColorUpdate G(float g) {
			return AddArgument( "g", g );
		}

		/// <summary>
		/// For the individual setting of the color blue.
		/// </summary>
		/// <param name="b"></param>
		/// <returns></returns>
		public iTweenColorUpdate B(float b) {
			return AddArgument( "b", b );
		}

		/// <summary>
		/// For the individual setting of the alpha.
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
		public iTweenColorUpdate A(float a) {
			return AddArgument( "a", a );
		}

		/// <summary>
		/// For which color of a shader to use. Uses "_Color" by default.
		/// </summary>
		/// <param name="namedColorValue"></param>
		/// <returns></returns>
		public iTweenColorUpdate NamedColorValue(string namedColorValue) {
			return AddArgument( "NamedColorValue", namedColorValue );
		}

		/// <summary>
		/// for whether or not to include children of this GameObject.
		/// True by default.
		/// </summary>
		/// <param name="includeChildren"></param>
		/// <returns></returns>
		public iTweenColorUpdate IncludeChildren(bool includeChildren) {
			return AddArgument( "includechildren", includeChildren );
		}

		/// <summary>
		/// For the time in seconds the animation will take to complete.
		/// </summary>
		/// <param name="time"></param>
		/// <returns></returns>
		public iTweenColorUpdate Time(float time) {
			return AddArgument( "time", time );
		}

		protected iTweenColorUpdate AddArgument(string arg, object value) {
			arguments[arg] = value;

			return this;
		}
	}

}
