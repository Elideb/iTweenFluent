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
	/// Adds supplied Euler angles in degrees to a GameObject's rotation over time.
	/// </summary>
	public class iTweenRotateAdd : iTweenFluent {

		public static iTweenRotateAdd Create(GameObject target) {
			return new iTweenRotateAdd( target );
		}

		public iTweenRotateAdd(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.RotateAdd( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For the amount of Euler angles in degrees to add
		/// to the current rotation of the GameObject.
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public iTweenRotateAdd Amount(Vector3 amount) {
			return AddArgument<iTweenRotateAdd>( "amount", amount );
		}

		/// <summary>
		/// For the individual setting of the x axis.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public iTweenRotateAdd X(float x) {
			return AddArgument<iTweenRotateAdd>( "x", x );
		}

		/// <summary>
		/// For the individual setting of the y axis.
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		public iTweenRotateAdd Y(float y) {
			return AddArgument<iTweenRotateAdd>( "y", y );
		}

		/// <summary>
		/// For the individual setting of the z axis.
		/// </summary>
		/// <param name="z"></param>
		/// <returns></returns>
		public iTweenRotateAdd Z(float z) {
			return AddArgument<iTweenRotateAdd>( "z", z );
		}

		/// <summary>
		/// For applying the transformation in either the world coordinate or local
		/// cordinate system. Defaults to local space.
		/// </summary>
		/// <param name="space"></param>
		/// <returns></returns>
		public iTweenRotateAdd Space(Space space) {
			return AddArgument<iTweenRotateAdd>( "space", space );
		}

		/// <summary>
		/// Can be used instead of time to allow animation based on speed.
		/// </summary>
		/// <param name="speed"></param>
		/// <returns></returns>
		public iTweenRotateAdd Speed(float speed) {
			return AddArgument<iTweenRotateAdd>( "speed", speed );
		}

	}

	/// <summary>
	/// Multiplies supplied values by 360 and rotates a GameObject by calculated
	/// amount over time.
	/// </summary>
	public class iTweenRotateBy : iTweenFluent {

		public static iTweenRotateBy Create(GameObject target) {
			return new iTweenRotateBy( target );
		}

		public iTweenRotateBy(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.RotateBy( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For the amount of Euler angles in degrees to add to the current
		/// rotation of the GameObject.
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public iTweenRotateBy Amount(Vector3 amount) {
			return AddArgument<iTweenRotateBy>( "amount", amount );
		}

		/// <summary>
		/// For the individual setting of the x axis.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public iTweenRotateBy X(float x) {
			return AddArgument<iTweenRotateBy>( "x", x );
		}

		/// <summary>
		/// For the individual setting of the y axis.
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		public iTweenRotateBy Y(float y) {
			return AddArgument<iTweenRotateBy>( "y", y );
		}

		/// <summary>
		/// For the individual setting of the z axis.
		/// </summary>
		/// <param name="z"></param>
		/// <returns></returns>
		public iTweenRotateBy Z(float z) {
			return AddArgument<iTweenRotateBy>( "z", z );
		}

		/// <summary>
		/// For applying the transformation in either the world coordinate or
		/// local cordinate system. Defaults to local space.
		/// </summary>
		/// <param name="space"></param>
		/// <returns></returns>
		public iTweenRotateBy Space(Space space) {
			return AddArgument<iTweenRotateBy>( "space", space );
		}

		/// <summary>
		/// Can be used instead of time to allow animation based on speed.
		/// </summary>
		/// <param name="speed"></param>
		/// <returns></returns>
		public iTweenRotateBy Speed(float speed) {
			return AddArgument<iTweenRotateBy>( "speed", speed );
		}

	}

	/// <summary>
	/// Instantly changes a GameObject's Euler angles in degrees then returns it
	/// to it's starting rotation over time.
	/// </summary>
	public class iTweenRotateFrom : iTweenFluent {

		public static iTweenRotateFrom Create(GameObject target) {
			return new iTweenRotateFrom( target );
		}

		public iTweenRotateFrom(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.RotateFrom( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For the target Euler angles in degrees to rotate to.
		/// </summary>
		/// <param name="rotation"></param>
		/// <returns></returns>
		public iTweenRotateFrom Rotation(Transform rotation) {
			return AddArgument<iTweenRotateFrom>( "rotation", rotation );
		}

		/// <summary>
		/// For the target Euler angles in degrees to rotate to.
		/// </summary>
		/// <param name="rotation"></param>
		/// <returns></returns>
		public iTweenRotateFrom Rotation(Vector3 rotation) {
			return AddArgument<iTweenRotateFrom>( "rotation", rotation );
		}

		/// <summary>
		/// For the individual setting of the x axis.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public iTweenRotateFrom X(float x) {
			return AddArgument<iTweenRotateFrom>( "x", x );
		}

		/// <summary>
		/// For the individual setting of the y axis.
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		public iTweenRotateFrom Y(float y) {
			return AddArgument<iTweenRotateFrom>( "y", y );
		}

		/// <summary>
		/// For the individual setting of the z axis.
		/// </summary>
		/// <param name="z"></param>
		/// <returns></returns>
		public iTweenRotateFrom Z(float z) {
			return AddArgument<iTweenRotateFrom>( "z", z );
		}

		/// <summary>
		/// For whether to animate in world space or relative to the parent.
		/// False be default.
		/// </summary>
		/// <param name="isLocal"></param>
		/// <returns></returns>
		public iTweenRotateFrom IsLocal(bool isLocal) {
			return AddArgument<iTweenRotateFrom>( "islocal", isLocal );
		}

		/// <summary>
		/// Can be used instead of time to allow animation based on speed.
		/// </summary>
		/// <param name="speed"></param>
		/// <returns></returns>
		public iTweenRotateFrom Speed(float speed) {
			return AddArgument<iTweenRotateFrom>( "speed", speed );
		}

	}

	/// <summary>
	/// Rotates a GameObject to the supplied Euler angles in degrees over time.
	/// </summary>
	public class iTweenRotateTo : iTweenFluent {

		public static iTweenRotateTo Create(GameObject target) {
			return new iTweenRotateTo( target );
		}

		public iTweenRotateTo(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.RotateTo( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For the target Euler angles in degrees to rotate to.
		/// </summary>
		/// <param name="rotation"></param>
		/// <returns></returns>
		public iTweenRotateTo Rotation(Transform rotation) {
			return AddArgument<iTweenRotateTo>( "rotation", rotation );
		}

		/// <summary>
		/// For the target Euler angles in degrees to rotate to.
		/// </summary>
		/// <param name="rotation"></param>
		/// <returns></returns>
		public iTweenRotateTo Rotation(Vector3 rotation) {
			return AddArgument<iTweenRotateTo>( "rotation", rotation );
		}

		/// <summary>
		/// For the individual setting of the x axis.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public iTweenRotateTo X(float x) {
			return AddArgument<iTweenRotateTo>( "x", x );
		}

		/// <summary>
		/// For the individual setting of the y axis.
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		public iTweenRotateTo Y(float y) {
			return AddArgument<iTweenRotateTo>( "y", y );
		}

		/// <summary>
		/// For the individual setting of the z axis.
		/// </summary>
		/// <param name="z"></param>
		/// <returns></returns>
		public iTweenRotateTo Z(float z) {
			return AddArgument<iTweenRotateTo>( "z", z );
		}

		/// <summary>
		/// For whether to animate in world space or relative to the parent.
		/// False be default.
		/// </summary>
		/// <param name="isLocal"></param>
		/// <returns></returns>
		public iTweenRotateTo IsLocal(bool isLocal) {
			return AddArgument<iTweenRotateTo>( "islocal", isLocal );
		}

		/// <summary>
		/// Can be used instead of time to allow animation based on speed.
		/// </summary>
		/// <param name="speed"></param>
		/// <returns></returns>
		public iTweenRotateTo Speed(float speed) {
			return AddArgument<iTweenRotateTo>( "speed", speed );
		}

	}

	/// <summary>
	/// Applies a jolt of force to a GameObject's rotation and wobbles it back
	/// to its initial rotation.
	/// NOTE: Due to the way iTween utilizes the Transform.Rotate method,
	/// PunchRotation works best with single axis usage rather than punching
	/// with a Vector3.
	/// </summary>
	public class iTweenPunchRotation : iTweenFluent {

		public static iTweenPunchRotation Create(GameObject target) {
			return new iTweenPunchRotation( target );
		}

		public iTweenPunchRotation(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.PunchRotation( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For a point in space the GameObject will animate to.
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public iTweenPunchRotation Amount(Vector3 amount) {
			return AddArgument<iTweenPunchRotation>( "amount", amount );
		}

		/// <summary>
		/// For the individual setting of the x axis.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public iTweenPunchRotation X(float x) {
			return AddArgument<iTweenPunchRotation>( "x", x );
		}

		/// <summary>
		/// For the individual setting of the y axis.
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		public iTweenPunchRotation Y(float y) {
			return AddArgument<iTweenPunchRotation>( "y", y );
		}

		/// <summary>
		/// For the individual setting of the z axis.
		/// </summary>
		/// <param name="z"></param>
		/// <returns></returns>
		public iTweenPunchRotation Z(float z) {
			return AddArgument<iTweenPunchRotation>( "z", z );
		}

		/// <summary>
		/// For applying the transformation in either the world coordinate or local
		/// cordinate system. Defaults to local space.
		/// </summary>
		/// <param name="space"></param>
		/// <returns></returns>
		public iTweenPunchRotation Space(Space space) {
			return AddArgument<iTweenPunchRotation>( "space", space );
		}

	}

	/// <summary>
	/// Randomly shakes a GameObject's rotation by a diminishing amount over time.
	/// </summary>
	public class iTweenShakeRotation : iTweenFluent {

		public static iTweenShakeRotation Create(GameObject target) {
			return new iTweenShakeRotation( target );
		}

		public iTweenShakeRotation(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.ShakeRotation( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For the magnitude of shake.
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public iTweenShakeRotation Amount(Vector3 amount) {
			return AddArgument<iTweenShakeRotation>( "amount", amount );
		}

		/// <summary>
		/// For the individual setting of the x axis.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public iTweenShakeRotation X(float x) {
			return AddArgument<iTweenShakeRotation>( "x", x );
		}

		/// <summary>
		/// For the individual setting of the y axis.
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		public iTweenShakeRotation Y(float y) {
			return AddArgument<iTweenShakeRotation>( "y", y );
		}

		/// <summary>
		/// For the individual setting of the z axis.
		/// </summary>
		/// <param name="z"></param>
		/// <returns></returns>
		public iTweenShakeRotation Z(float z) {
			return AddArgument<iTweenShakeRotation>( "z", z );
		}

		/// <summary>
		/// For applying the transformation in either the world coordinate or local
		/// coordinate system. Defaults to local space.
		/// </summary>
		/// <param name="space"></param>
		/// <returns></returns>
		public iTweenShakeRotation Space(Space space) {
			return AddArgument<iTweenShakeRotation>( "space", space );
		}

	}

	/// <summary>
	/// Similar to RotateTo but incredibly less expensive for usage inside the
	/// Update function or similar looping situations involving a "live" set
	/// of changing values. Does not utilize an EaseType.
	/// </summary>
	public class iTweenRotateUpdate {
		private GameObject target;

		private Dictionary<string, object> arguments = new Dictionary<string, object>();

		public static iTweenRotateUpdate Create(GameObject target) {
			return new iTweenRotateUpdate( target );
		}

		public iTweenRotateUpdate(GameObject target) {
			this.target = target;
		}

		public void Launch() {
			iTween.RotateUpdate( target, new System.Collections.Hashtable( arguments ) );
		}

		/// <summary>
		/// For the target Euler angles in degrees to rotate to.
		/// </summary>
		/// <param name="rotation"></param>
		/// <returns></returns>
		public iTweenRotateUpdate Rotation(Transform rotation) {
			return AddArgument( "rotation", rotation );
		}

		/// <summary>
		/// For the target Euler angles in degrees to rotate to.
		/// </summary>
		/// <param name="rotation"></param>
		/// <returns></returns>
		public iTweenRotateUpdate Rotation(Vector3 rotation) {
			return AddArgument( "rotation", rotation );
		}

		/// <summary>
		/// For the individual setting of the x axis.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public iTweenRotateUpdate X(float x) {
			return AddArgument( "x", x );
		}

		/// <summary>
		/// For the individual setting of the y axis.
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		public iTweenRotateUpdate Y(float y) {
			return AddArgument( "y", y );
		}

		/// <summary>
		/// For the individual setting of the z axis.
		/// </summary>
		/// <param name="z"></param>
		/// <returns></returns>
		public iTweenRotateUpdate Z(float z) {
			return AddArgument( "z", z );
		}

		/// <summary>
		/// For whether to animate in world space or relative to the parent.
		/// False be default.
		/// </summary>
		/// <param name="isLocal"></param>
		/// <returns></returns>
		public iTweenRotateUpdate IsLocal(bool isLocal) {
			return AddArgument( "islocal", isLocal );
		}

		/// <summary>
		/// For the time in seconds the animation will take to complete.
		/// </summary>
		/// <param name="time"></param>
		/// <returns></returns>
		public iTweenRotateUpdate Time(float time) {
			return AddArgument( "time", time );
		}

		protected iTweenRotateUpdate AddArgument(string arg, object value) {
			arguments[arg] = value;

			return this;
		}
	}

}
