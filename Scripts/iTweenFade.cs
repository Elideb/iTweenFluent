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
	/// Changes a GameObject's alpha value instantly then returns it to the
	/// provided alpha over time. If a Light, GUIText or GUITexture component
	/// is attached, it will become the target of the animation.
	/// Identical to using ColorFrom and using the "a" parameter.
	/// </summary>
	public class iTweenFadeFrom : iTweenFluent {

		public static iTweenFadeFrom Create(GameObject target) {
			return new iTweenFadeFrom( target );
		}

		public iTweenFadeFrom(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.FadeFrom( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For the initial alpha value of the animation.
		/// </summary>
		/// <param name="alpha"></param>
		/// <returns></returns>
		public iTweenFadeFrom Alpha(float alpha) {
			return AddArgument<iTweenFadeFrom>( "alpha", alpha );
		}

		/// <summary>
		/// For the initial alpha value of the animation.
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public iTweenFadeFrom Amount(float amount) {
			return AddArgument<iTweenFadeFrom>( "amount", amount );
		}

		/// <summary>
		/// For which color of a shader to use. Uses "_Color" by default.
		/// </summary>
		/// <param name="namedValueColor"></param>
		/// <returns></returns>
		public iTweenFadeFrom NamedValueColor(string namedValueColor) {
			return AddArgument<iTweenFadeFrom>( "NamedValueColor", namedValueColor );
		}

		/// <summary>
		/// For whether or not to include children of this GameObject. True by default.
		/// </summary>
		/// <param name="includeChildren"></param>
		/// <returns></returns>
		public iTweenFadeFrom IncludeChildren(bool includeChildren) {
			return AddArgument<iTweenFadeFrom>( "includechildren", includeChildren );
		}
	}

	/// <summary>
	/// Changes a GameObject's alpha value over time. If a Light, GUIText or
	/// GUITexture component is attached, it will become the target of the
	/// animation. Identical to using ColorTo and using the "a" parameter.
	/// </summary>
	public class iTweenFadeTo : iTweenFluent {

		public static iTweenFadeTo Create(GameObject target) {
			return new iTweenFadeTo( target );
		}

		public iTweenFadeTo(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.FadeTo( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For the initial alpha value of the animation.
		/// </summary>
		/// <param name="alpha"></param>
		/// <returns></returns>
		public iTweenFadeTo Alpha(float alpha) {
			return AddArgument<iTweenFadeTo>( "alpha", alpha );
		}

		/// <summary>
		/// For the amount to change the alpha.
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public iTweenFadeTo Amount(float amount) {
			return AddArgument<iTweenFadeTo>( "amount", amount );
		}

		/// <summary>
		/// For which color of a shader to use. Uses "_Color" by default.
		/// </summary>
		/// <param name="namedValueColor"></param>
		/// <returns></returns>
		public iTweenFadeTo NamedValueColor(string namedValueColor) {
			return AddArgument<iTweenFadeTo>( "NamedValueColor", namedValueColor );
		}

		/// <summary>
		/// For whether or not to include children of this GameObject.
		/// True by default.
		/// </summary>
		/// <param name="includeChildren"></param>
		/// <returns></returns>
		public iTweenFadeTo IncludeChildren(bool includeChildren) {
			return AddArgument<iTweenFadeTo>( "includechildren", includeChildren );
		}
	}

	/// <summary>
	/// Similar to FadeTo but incredibly less expensive for usage inside the
	/// Update function or similar looping situations involving a "live" set of
	/// changing values. Does not utilize an EaseType.
	/// </summary>
	public class iTweenFadeUpdate {
		private GameObject target;

		private Dictionary<string, object> arguments = new Dictionary<string, object>();

		public static iTweenFadeUpdate Create(GameObject target) {
			return new iTweenFadeUpdate( target );
		}

		public iTweenFadeUpdate(GameObject target) {
			this.target = target;
		}

		public void Launch() {
			iTween.FadeUpdate( target, new System.Collections.Hashtable( arguments ) );
		}

		/// <summary>
		/// For the individual setting of the alpha.
		/// </summary>
		/// <param name="alpha"></param>
		/// <returns></returns>
		public iTweenFadeUpdate Alpha(float alpha) {
			return AddArgument( "alpha", alpha );
		}

		/// <summary>
		/// For whether or not to include children of this GameObject.
		/// True by default.
		/// </summary>
		/// <param name="includeChildren"></param>
		/// <returns></returns>
		public iTweenFadeUpdate IncludeChildren(bool includeChildren) {
			return AddArgument( "includechildren", includeChildren );
		}

		/// <summary>
		/// For the time in seconds the animation will take to complete.
		/// </summary>
		/// <param name="time"></param>
		/// <returns></returns>
		public iTweenFadeUpdate Time(float time) {
			return AddArgument( "time", time );
		}

		protected iTweenFadeUpdate AddArgument(string arg, object value) {
			arguments[arg] = value;

			return this;
		}
	}

}
