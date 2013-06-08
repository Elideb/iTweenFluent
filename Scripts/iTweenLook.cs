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
	/// Instantly rotates a GameObject to look at the supplied Vector3 then
	/// returns it to it's starting rotation over time.
	/// </summary>
	public class iTweenLookFrom : iTweenFluent<iTweenLookFrom> {

		public static iTweenLookFrom Create(GameObject target) {
			return new iTweenLookFrom( target );
		}

		public iTweenLookFrom(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.LookFrom( Target, new System.Collections.Hashtable( Arguments ) );
		}

		protected override iTweenLookFrom ThisAsTSelf() {
			return this;
		}

		/// <summary>
		/// For a target the GameObject will look at.
		/// </summary>
		/// <param name="lookTarget"></param>
		/// <returns></returns>
		public iTweenLookFrom LookTarget(Transform lookTarget) {
			return AddArgument( "looktarget", lookTarget );
		}

		/// <summary>
		/// For a target the GameObject will look at.
		/// </summary>
		/// <param name="lookTarget"></param>
		/// <returns></returns>
		public iTweenLookFrom LookTarget(Vector3 lookTarget) {
			return AddArgument( "looktarget", lookTarget );
		}

		/// <summary>
		/// Restricts rotation to the supplied axis only.
		/// </summary>
		/// <param name="axis"></param>
		/// <returns></returns>
		public iTweenLookFrom Axis(string axis) {
			return AddArgument( "axis", axis );
		}

		/// <summary>
		/// Can be used instead of time to allow animation based on speed.
		/// </summary>
		/// <param name="speed"></param>
		/// <returns></returns>
		public iTweenLookFrom Speed(float speed) {
			return AddArgument( "speed", speed );
		}

	}

	/// <summary>
	/// Rotates a GameObject to look at a supplied Transform or Vector3 over time.
	/// </summary>
	public class iTweenLookTo : iTweenFluent<iTweenLookTo> {

		public static iTweenLookTo Create(GameObject target) {
			return new iTweenLookTo( target );
		}

		public iTweenLookTo(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.LookTo( Target, new System.Collections.Hashtable( Arguments ) );
		}

		protected override iTweenLookTo ThisAsTSelf() {
			return this;
		}

		/// <summary>
		/// For a target the GameObject will look at.
		/// </summary>
		/// <param name="lookTarget"></param>
		/// <returns></returns>
		public iTweenLookTo LookTarget(Transform lookTarget) {
			return AddArgument( "looktarget", lookTarget );
		}

		/// <summary>
		/// For a target the GameObject will look at.
		/// </summary>
		/// <param name="lookTarget"></param>
		/// <returns></returns>
		public iTweenLookTo LookTarget(Vector3 lookTarget) {
			return AddArgument( "looktarget", lookTarget );
		}

		/// <summary>
		/// Restricts rotation to the supplied axis only.
		/// </summary>
		/// <param name="axis"></param>
		/// <returns></returns>
		public iTweenLookTo Axis(string axis) {
			return AddArgument( "axis", axis );
		}

		/// <summary>
		/// Can be used instead of time to allow animation based on speed.
		/// </summary>
		/// <param name="speed"></param>
		/// <returns></returns>
		public iTweenLookTo Speed(float speed) {
			return AddArgument( "speed", speed );
		}

	}

	/// <summary>
	/// 
	/// </summary>
	public class iTweenLookUpdate {
		private GameObject target;

		private Dictionary<string, object> arguments = new Dictionary<string, object>();

		public static iTweenLookUpdate Create(GameObject target) {
			return new iTweenLookUpdate( target );
		}

		public iTweenLookUpdate(GameObject target) {
			this.target = target;
		}

		public void Launch() {
			iTween.AudioUpdate( target, new System.Collections.Hashtable( arguments ) );
		}

		/// <summary>
		/// For a target the GameObject will look at.
		/// </summary>
		/// <param name="lookTarget"></param>
		/// <returns></returns>
		public iTweenLookUpdate LookTarget(Transform lookTarget) {
			return AddArgument( "looktarget", lookTarget );
		}

		/// <summary>
		/// For a target the GameObject will look at.
		/// </summary>
		/// <param name="lookTarget"></param>
		/// <returns></returns>
		public iTweenLookUpdate LookTarget(Vector3 lookTarget) {
			return AddArgument( "looktarget", lookTarget );
		}

		/// <summary>
		/// Restricts rotation to the supplied axis only.
		/// </summary>
		/// <param name="axis"></param>
		/// <returns></returns>
		public iTweenLookUpdate Axis(string axis) {
			return AddArgument( "axis", axis );
		}

		/// <summary>
		/// For the time in seconds the animation will take to complete.
		/// </summary>
		/// <param name="time"></param>
		/// <returns></returns>
		public iTweenLookUpdate Time(float time) {
			return AddArgument( "time", time );
		}

		protected iTweenLookUpdate AddArgument(string arg, object value) {
			arguments[arg] = value;

			return this;
		}
	}

}
