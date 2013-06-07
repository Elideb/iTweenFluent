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
	/// Adds to a GameObject's scale over time.
	/// </summary>
	public class iTweenScaleAdd : iTweenFluent {

		public static iTweenScaleAdd Create(GameObject target) {
			return new iTweenScaleAdd( target );
		}

		public iTweenScaleAdd(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.ScaleAdd( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For the amount to be added to the GameObject's current scale.
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public iTweenScaleAdd Amount(Vector3 amount) {
			return AddArgument<iTweenScaleAdd>( "amount", amount );
		}

		/// <summary>
		/// For the individual setting of the x axis.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public iTweenScaleAdd X(float x) {
			return AddArgument<iTweenScaleAdd>( "x", x );
		}

		/// <summary>
		/// For the individual setting of the y axis
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		public iTweenScaleAdd Y(float y) {
			return AddArgument<iTweenScaleAdd>( "y", y );
		}

		/// <summary>
		/// For the individual setting of the z axis.
		/// </summary>
		/// <param name="z"></param>
		/// <returns></returns>
		public iTweenScaleAdd Z(float z) {
			return AddArgument<iTweenScaleAdd>( "z", z );
		}

		/// <summary>
		/// Can be used instead of time to allow animation based on speed.
		/// </summary>
		/// <param name="speed"></param>
		/// <returns></returns>
		public iTweenScaleAdd Speed(float speed) {
			return AddArgument<iTweenScaleAdd>( "speed", speed );
		}

	}

	/// <summary>
	/// Multiplies a GameObject's scale over time.
	/// </summary>
	public class iTweenScaleBy : iTweenFluent {

		public static iTweenScaleBy Create(GameObject target) {
			return new iTweenScaleBy( target );
		}

		public iTweenScaleBy(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.ScaleBy( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For the amount to be added to the GameObject's current scale.
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public iTweenScaleBy Amount(Vector3 amount) {
			return AddArgument<iTweenScaleBy>( "amount", amount );
		}

		/// <summary>
		/// For the individual setting of the x axis.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public iTweenScaleBy X(float x) {
			return AddArgument<iTweenScaleBy>( "x", x );
		}

		/// <summary>
		/// For the individual setting of the y axis.
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		public iTweenScaleBy Y(float y) {
			return AddArgument<iTweenScaleBy>( "y", y );
		}

		/// <summary>
		/// For the individual setting of the z axis.
		/// </summary>
		/// <param name="z"></param>
		/// <returns></returns>
		public iTweenScaleBy Z(float z) {
			return AddArgument<iTweenScaleBy>( "z", z );
		}

		/// <summary>
		/// Can be used instead of time to allow animation based on speed.
		/// </summary>
		/// <param name="speed"></param>
		/// <returns></returns>
		public iTweenScaleBy Speed(float speed) {
			return AddArgument<iTweenScaleBy>( "speed", speed );
		}

	}

	/// <summary>
	/// Instantly changes a GameObject's scale then returns it to it's starting
	/// scale over time.
	/// </summary>
	public class iTweenScaleFrom : iTweenFluent {

		public static iTweenScaleFrom Create(GameObject target) {
			return new iTweenScaleFrom( target );
		}

		public iTweenScaleFrom(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.ScaleFrom( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For the initial scale.
		/// </summary>
		/// <param name="scale"></param>
		/// <returns></returns>
		public iTweenScaleFrom Scale(Transform scale) {
			return AddArgument<iTweenScaleFrom>( "scale", scale );
		}

		/// <summary>
		/// For the initial scale.
		/// </summary>
		/// <param name="scale"></param>
		/// <returns></returns>
		public iTweenScaleFrom Scale(Vector3 scale) {
			return AddArgument<iTweenScaleFrom>( "scale", scale );
		}

		/// <summary>
		/// For the individual setting of the x axis.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public iTweenScaleFrom X(float x) {
			return AddArgument<iTweenScaleFrom>( "x", x );
		}

		/// <summary>
		/// For the individual setting of the y axis.
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		public iTweenScaleFrom Y(float y) {
			return AddArgument<iTweenScaleFrom>( "y", y );
		}

		/// <summary>
		/// For the individual setting of the z axis
		/// </summary>
		/// <param name="z"></param>
		/// <returns></returns>
		public iTweenScaleFrom Z(float z) {
			return AddArgument<iTweenScaleFrom>( "z", z );
		}

		/// <summary>
		/// Can be used instead of time to allow animation based on speed.
		/// </summary>
		/// <param name="speed"></param>
		/// <returns></returns>
		public iTweenScaleFrom Speed(float speed) {
			return AddArgument<iTweenScaleFrom>( "speed", speed );
		}

	}

	/// <summary>
	/// Changes a GameObject's scale over time.
	/// </summary>
	public class iTweenScaleTo : iTweenFluent {

		public static iTweenScaleTo Create(GameObject target) {
			return new iTweenScaleTo( target );
		}

		public iTweenScaleTo(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.ScaleTo( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For the final scale.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public iTweenScaleTo Scale(Transform scale) {
			return AddArgument<iTweenScaleTo>( "scale", scale );
		}

		/// <summary>
		/// For the final scale.
		/// </summary>
		/// <param name="scale"></param>
		/// <returns></returns>
		public iTweenScaleTo Scale(Vector3 scale) {
			return AddArgument<iTweenScaleTo>( "scale", scale );
		}

		/// <summary>
		/// For the individual setting of the x axis.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public iTweenScaleTo X(float x) {
			return AddArgument<iTweenScaleTo>( "x", x );
		}

		/// <summary>
		/// For the individual setting of the y axis.
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		public iTweenScaleTo Y(float y) {
			return AddArgument<iTweenScaleTo>( "y", y );
		}

		/// <summary>
		/// For the individual setting of the z axis.
		/// </summary>
		/// <param name="z"></param>
		/// <returns></returns>
		public iTweenScaleTo Z(float z) {
			return AddArgument<iTweenScaleTo>( "z", z );
		}

		/// <summary>
		/// Can be used instead of time to allow animation based on speed.
		/// </summary>
		/// <param name="speed"></param>
		/// <returns></returns>
		public iTweenScaleTo Speed(float speed) {
			return AddArgument<iTweenScaleTo>( "speed", speed );
		}

	}

	/// <summary>
	/// Applies a jolt of force to a GameObject's scale and wobbles it back to its
	/// initial scale.
	/// </summary>
	public class iTweenPunchScale : iTweenFluent {

		public static iTweenPunchScale Create(GameObject target) {
			return new iTweenPunchScale( target );
		}

		public iTweenPunchScale(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.PunchScale( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For the scale the GameObject will animate to.
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public iTweenPunchScale Amount(Vector3 amount) {
			return AddArgument<iTweenPunchScale>( "amount", amount );
		}

		/// <summary>
		/// For the individual setting of the x magnitude.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public iTweenPunchScale X(float x) {
			return AddArgument<iTweenPunchScale>( "x", x );
		}

		/// <summary>
		/// For the individual setting of the y magnitude.
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		public iTweenPunchScale Y(float y) {
			return AddArgument<iTweenPunchScale>( "y", y );
		}

		/// <summary>
		/// For the individual setting of the z magnitude.
		/// </summary>
		/// <param name="z"></param>
		/// <returns></returns>
		public iTweenPunchScale Z(float z) {
			return AddArgument<iTweenPunchScale>( "z", z );
		}

	}

	/// <summary>
	/// Randomly shakes a GameObject's scale by a diminishing amount over time.
	/// </summary>
	public class iTweenShakeScale : iTweenFluent {

		public static iTweenShakeScale Create(GameObject target) {
			return new iTweenShakeScale( target );
		}

		public iTweenShakeScale(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.ShakeScale( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For the magnitude of shake.
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public iTweenShakeScale Amount(Vector3 amount) {
			return AddArgument<iTweenShakeScale>( "amount", amount );
		}

		/// <summary>
		/// For the individual setting of the x magnitude.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public iTweenShakeScale X(float x) {
			return AddArgument<iTweenShakeScale>( "x", x );
		}

		/// <summary>
		/// For the individual setting of the y magnitude.
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		public iTweenShakeScale Y(float y) {
			return AddArgument<iTweenShakeScale>( "y", y );
		}

		/// <summary>
		/// For the individual setting of the z magnitude.
		/// </summary>
		/// <param name="z"></param>
		/// <returns></returns>
		public iTweenShakeScale Z(float z) {
			return AddArgument<iTweenShakeScale>( "z", z );
		}

	}

	/// <summary>
	/// Similar to ScaleTo but incredibly less expensive for usage inside the
	/// Update function or similar looping situations involving a "live" set
	/// of changing values. Does not utilize an EaseType.
	/// </summary>
	public class iTweenScaleUpdate {
		private GameObject target;

		private Dictionary<string, object> arguments = new Dictionary<string, object>();

		public static iTweenScaleUpdate Create(GameObject target) {
			return new iTweenScaleUpdate( target );
		}

		public iTweenScaleUpdate(GameObject target) {
			this.target = target;
		}

		public void Launch() {
			iTween.ScaleUpdate( target, new System.Collections.Hashtable( arguments ) );
		}

		/// <summary>
		/// For the final scale.
		/// </summary>
		/// <param name="scale"></param>
		/// <returns></returns>
		public iTweenScaleUpdate Scale(Transform scale) {
			return AddArgument( "scale", scale );
		}

		/// <summary>
		/// For the final scale.
		/// </summary>
		/// <param name="scale"></param>
		/// <returns></returns>
		public iTweenScaleUpdate Scale(Vector3 scale) {
			return AddArgument( "scale", scale );
		}

		/// <summary>
		/// For the individual setting of the x axis.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public iTweenScaleUpdate X(float x) {
			return AddArgument( "x", x );
		}

		/// <summary>
		/// For the individual setting of the y axis.
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		public iTweenScaleUpdate Y(float y) {
			return AddArgument( "y", y );
		}

		/// <summary>
		/// For the individual setting of the z axis.
		/// </summary>
		/// <param name="z"></param>
		/// <returns></returns>
		public iTweenScaleUpdate Z(float z) {
			return AddArgument( "z", z );
		}

		/// <summary>
		/// For the time in seconds the animation will take to complete.
		/// </summary>
		/// <param name="time"></param>
		/// <returns></returns>
		public iTweenScaleUpdate Time(float time) {
			return AddArgument( "time", time );
		}

		protected iTweenScaleUpdate AddArgument(string arg, object value) {
			arguments[arg] = value;

			return this;
		}
	}

}
