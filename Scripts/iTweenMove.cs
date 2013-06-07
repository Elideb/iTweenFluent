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
	/// Translates a GameObject's position over time.
	/// </summary>
	public class iTweenMoveAdd : iTweenFluent {

		public static iTweenMoveAdd Create(GameObject target) {
			return new iTweenMoveAdd( target );
		}

		public iTweenMoveAdd(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.MoveAdd( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For a point in space the GameObject will animate to.
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public iTweenMoveAdd Amount(Vector3 amount) {
			return AddArgument<iTweenMoveAdd>( "amount", amount );
		}

		/// <summary>
		/// For the individual setting of the x axis
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public iTweenMoveAdd X(float x) {
			return AddArgument<iTweenMoveAdd>( "x", x );
		}

		/// <summary>
		/// for the individual setting of the y axis
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		public iTweenMoveAdd Y(float y) {
			return AddArgument<iTweenMoveAdd>( "y", y );
		}

		/// <summary>
		/// for the individual setting of the z axis
		/// </summary>
		/// <param name="z"></param>
		/// <returns></returns>
		public iTweenMoveAdd Z(float z) {
			return AddArgument<iTweenMoveAdd>( "z", z );
		}

		/// <summary>
		/// For whether or not the GameObject will orient to its direction of travel.
		/// False by default
		/// </summary>
		/// <param name="orientToPath"></param>
		/// <returns></returns>
		public iTweenMoveAdd OrientToPath(bool orientToPath) {
			return AddArgument<iTweenMoveAdd>( "orienttopath", orientToPath );
		}

		/// <summary>
		/// For a target the GameObject will look at.
		/// </summary>
		/// <param name="lookTarget"></param>
		/// <returns></returns>
		public iTweenMoveAdd LookTarget(Transform lookTarget) {
			return AddArgument<iTweenMoveAdd>( "looktarget", lookTarget );
		}

		/// <summary>
		/// For a target the GameObject will look at.
		/// </summary>
		/// <param name="lookTarget"></param>
		/// <returns></returns>
		public iTweenMoveAdd LookTarget(Vector3 lookTarget) {
			return AddArgument<iTweenMoveAdd>( "looktarget", lookTarget );
		}

		/// <summary>
		/// For the time in seconds the object will take to look at either the
		/// "looktarget" or "orienttopath".
		/// </summary>
		/// <param name="lookTime"></param>
		/// <returns></returns>
		public iTweenMoveAdd LookTime(float lookTime) {
			return AddArgument<iTweenMoveAdd>( "looktime", lookTime );
		}

		/// <summary>
		/// Restricts rotation to the supplied axis only.
		/// </summary>
		/// <param name="axis"></param>
		/// <returns></returns>
		public iTweenMoveAdd Axis(string axis) {
			return AddArgument<iTweenMoveAdd>( "axis", axis );
		}

		/// <summary>
		/// For applying the transformation in either the world coordinate or local
		/// cordinate system. Defaults to local space.
		/// </summary>
		/// <param name="space"></param>
		/// <returns></returns>
		public iTweenMoveAdd Space(Space space) {
			return AddArgument<iTweenMoveAdd>( "space", space );
		}

		/// <summary>
		/// Can be used instead of time to allow animation based on speed.
		/// </summary>
		/// <param name="speed"></param>
		/// <returns></returns>
		public iTweenMoveAdd Speed(float speed) {
			return AddArgument<iTweenMoveAdd>( "speed", speed );
		}

	}

	/// <summary>
	/// Adds the supplied coordinates to a GameObject's position.
	/// </summary>
	public class iTweenMoveBy : iTweenFluent {

		public static iTweenMoveBy Create(GameObject target) {
			return new iTweenMoveBy( target );
		}

		public iTweenMoveBy(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.MoveBy( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For a point in space the GameObject will animate to.
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public iTweenMoveBy Amount(Vector3 amount) {
			return AddArgument<iTweenMoveBy>( "amount", amount );
		}

		/// <summary>
		/// for the individual setting of the x axis
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public iTweenMoveBy X(float x) {
			return AddArgument<iTweenMoveBy>( "x", x );
		}

		/// <summary>
		/// for the individual setting of the y axis
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		public iTweenMoveBy Y(float y) {
			return AddArgument<iTweenMoveBy>( "y", y );
		}

		/// <summary>
		/// for the individual setting of the z axis
		/// </summary>
		/// <param name="z"></param>
		/// <returns></returns>
		public iTweenMoveBy Z(float z) {
			return AddArgument<iTweenMoveBy>( "z", z );
		}

		/// <summary>
		/// For whether or not the GameObject will orient to its direction of travel.
		/// False by default.
		/// </summary>
		/// <param name="orientToPath"></param>
		/// <returns></returns>
		public iTweenMoveBy OrientToPath(bool orientToPath) {
			return AddArgument<iTweenMoveBy>( "orienttopath", orientToPath );
		}

		/// <summary>
		/// For a target the GameObject will look at.
		/// </summary>
		/// <param name="lookTarget"></param>
		/// <returns></returns>
		public iTweenMoveBy LookTarget(Transform lookTarget) {
			return AddArgument<iTweenMoveBy>( "looktarget", lookTarget );
		}

		/// <summary>
		/// For a target the GameObject will look at.
		/// </summary>
		/// <param name="lookTarget"></param>
		/// <returns></returns>
		public iTweenMoveBy LookTarget(Vector3 lookTarget) {
			return AddArgument<iTweenMoveBy>( "looktarget", lookTarget );
		}

		/// <summary>
		/// For the time in seconds the object will take to look at either
		/// the "looktarget" or "orienttopath"
		/// </summary>
		/// <param name="lookTime"></param>
		/// <returns></returns>
		public iTweenMoveBy LookTime(float lookTime) {
			return AddArgument<iTweenMoveBy>( "looktime", lookTime );
		}

		/// <summary>
		/// Restricts rotation to the supplied axis only.
		/// </summary>
		/// <param name="axis"></param>
		/// <returns></returns>
		public iTweenMoveBy Axis(string axis) {
			return AddArgument<iTweenMoveBy>( "axis", axis );
		}

		/// <summary>
		/// For applying the transformation in either the world coordinate or local
		/// cordinate system. Defaults to local space
		/// </summary>
		/// <param name="space"></param>
		/// <returns></returns>
		public iTweenMoveBy Space(Space space) {
			return AddArgument<iTweenMoveBy>( "space", space );
		}

		/// <summary>
		/// Can be used instead of time to allow animation based on speed.
		/// </summary>
		/// <param name="speed"></param>
		/// <returns></returns>
		public iTweenMoveBy Speed(float speed) {
			return AddArgument<iTweenMoveBy>( "speed", speed );
		}

	}

	/// <summary>
	/// Instantly changes a GameObject's position to a supplied destination then
	/// returns it to it's starting position over time.
	/// </summary>
	public class iTweenMoveFrom : iTweenFluent {

		public static iTweenMoveFrom Create(GameObject target) {
			return new iTweenMoveFrom( target );
		}

		public iTweenMoveFrom(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.MoveFrom( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For a point in space the GameObject will animate to.
		/// </summary>
		/// <param name="position"></param>
		/// <returns></returns>
		public iTweenMoveFrom Position(Transform position) {
			return AddArgument<iTweenMoveFrom>( "position", position );
		}

		/// <summary>
		/// For a point in space the GameObject will animate to.
		/// </summary>
		/// <param name="position"></param>
		/// <returns></returns>
		public iTweenMoveFrom Position(Vector3 position) {
			return AddArgument<iTweenMoveFrom>( "position", position );
		}

		/// <summary>
		/// For a list of points to draw a Catmull-Rom through for a curved
		/// animation path.
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public iTweenMoveFrom Path(Transform[] path) {
			return AddArgument<iTweenMoveFrom>( "path", path );
		}

		/// <summary>
		/// For a list of points to draw a Catmull-Rom through for a curved
		/// animation path.
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public iTweenMoveFrom Path(Vector3[] path) {
			return AddArgument<iTweenMoveFrom>( "path", path );
		}

		/// <summary>
		/// For whether to automatically generate a curve from the GameObject's
		/// current position to the beginning of the path. True by default.
		/// </summary>
		/// <param name="moveToPath"></param>
		/// <returns></returns>
		public iTweenMoveFrom MoveToPath(bool moveToPath) {
			return AddArgument<iTweenMoveFrom>( "movetopath", moveToPath );
		}

		/// <summary>
		/// for the individual setting of the x axis
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public iTweenMoveFrom X(float x) {
			return AddArgument<iTweenMoveFrom>( "x", x );
		}

		/// <summary>
		/// for the individual setting of the y axis
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		public iTweenMoveFrom Y(float y) {
			return AddArgument<iTweenMoveFrom>( "y", y );
		}

		/// <summary>
		/// for the individual setting of the z axis
		/// </summary>
		/// <param name="z"></param>
		/// <returns></returns>
		public iTweenMoveFrom Z(float z) {
			return AddArgument<iTweenMoveFrom>( "z", z );
		}

		/// <summary>
		/// For whether or not the GameObject will orient to its direction of travel.
		/// False by default.
		/// </summary>
		/// <param name="orientToPath"></param>
		/// <returns></returns>
		public iTweenMoveFrom OrientToPath(bool orientToPath) {
			return AddArgument<iTweenMoveFrom>( "orienttopath", orientToPath );
		}

		/// <summary>
		/// For a target the GameObject will look at.
		/// </summary>
		/// <param name="lookTarget"></param>
		/// <returns></returns>
		public iTweenMoveFrom LookTarget(Transform lookTarget) {
			return AddArgument<iTweenMoveFrom>( "looktarget", lookTarget );
		}

		/// <summary>
		/// For a target the GameObject will look at.
		/// </summary>
		/// <param name="lookTarget"></param>
		/// <returns></returns>
		public iTweenMoveFrom LookTarget(Vector3 lookTarget) {
			return AddArgument<iTweenMoveFrom>( "looktarget", lookTarget );
		}

		/// <summary>
		/// For the time in seconds the object will take to look at either
		/// the "looktarget" or "orienttopath".
		/// </summary>
		/// <param name="lookTime"></param>
		/// <returns></returns>
		public iTweenMoveFrom LookTime(float lookTime) {
			return AddArgument<iTweenMoveFrom>( "looktime", lookTime );
		}

		/// <summary>
		/// For how much of a percentage (from 0 to 1) to look ahead on a path to
		/// influence how strict "orienttopath" is and how much the object will
		/// anticipate each curve.
		/// </summary>
		/// <param name="lookAhead"></param>
		/// <returns></returns>
		public iTweenMoveFrom LookAhead(float lookAhead) {
			return AddArgument<iTweenMoveFrom>( "lookahead", lookAhead );
		}

		/// <summary>
		/// Restricts rotation to the supplied axis only.
		/// </summary>
		/// <param name="axis"></param>
		/// <returns></returns>
		public iTweenMoveFrom Axis(string axis) {
			return AddArgument<iTweenMoveFrom>( "axis", axis );
		}

		/// <summary>
		/// For whether to animate in world space or relative to the parent.
		/// False be default.
		/// </summary>
		/// <param name="isLocal"></param>
		/// <returns></returns>
		public iTweenMoveFrom IsLocal(bool isLocal) {
			return AddArgument<iTweenMoveFrom>( "islocal", isLocal );
		}

		/// <summary>
		/// Can be used instead of time to allow animation based on speed.
		/// </summary>
		/// <param name="speed"></param>
		/// <returns></returns>
		public iTweenMoveFrom Speed(float speed) {
			return AddArgument<iTweenMoveFrom>( "speed", speed );
		}

	}

	/// <summary>
	/// Changes a GameObject's position over time to a supplied destination.
	/// </summary>
	public class iTweenMoveTo : iTweenFluent {

		public static iTweenMoveTo Create(GameObject target) {
			return new iTweenMoveTo( target );
		}

		public iTweenMoveTo(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.MoveTo( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For a point in space the GameObject will animate to.
		/// </summary>
		/// <param name="position"></param>
		/// <returns></returns>
		public iTweenMoveTo Position(Transform position) {
			return AddArgument<iTweenMoveTo>( "position", position );
		}

		/// <summary>
		/// For a point in space the GameObject will animate to.
		/// </summary>
		/// <param name="position"></param>
		/// <returns></returns>
		public iTweenMoveTo Position(Vector3 position) {
			return AddArgument<iTweenMoveTo>( "position", position );
		}

		/// <summary>
		/// For a list of points to draw a Catmull-Rom through for a curved animation path.
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public iTweenMoveTo Path(Transform[] path) {
			return AddArgument<iTweenMoveTo>( "path", path );
		}

		/// <summary>
		/// For a list of points to draw a Catmull-Rom through for a curved animation path.
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public iTweenMoveTo Path(Vector3[] path) {
			return AddArgument<iTweenMoveTo>( "path", path );
		}

		/// <summary>
		/// For whether to automatically generate a curve from the GameObject's
		/// current position to the beginning of the path. True by default.
		/// </summary>
		/// <param name="moveToPath"></param>
		/// <returns></returns>
		public iTweenMoveTo MoveToPath(bool moveToPath) {
			return AddArgument<iTweenMoveTo>( "movetopath", moveToPath );
		}

		/// <summary>
		/// for the individual setting of the x axis
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public iTweenMoveTo X(float x) {
			return AddArgument<iTweenMoveTo>( "x", x );
		}

		/// <summary>
		/// for the individual setting of the y axis
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		public iTweenMoveTo Y(float y) {
			return AddArgument<iTweenMoveTo>( "y", y );
		}

		/// <summary>
		/// for the individual setting of the z axis
		/// </summary>
		/// <param name="z"></param>
		/// <returns></returns>
		public iTweenMoveTo Z(float z) {
			return AddArgument<iTweenMoveTo>( "z", z );
		}

		/// <summary>
		/// For whether or not the GameObject will orient to its direction of travel.
		/// False by default.
		/// </summary>
		/// <param name="orientToPath"></param>
		/// <returns></returns>
		public iTweenMoveTo OrientToPath(bool orientToPath) {
			return AddArgument<iTweenMoveTo>( "orienttopath", orientToPath );
		}

		/// <summary>
		/// For a target the GameObject will look at.
		/// </summary>
		/// <param name="lookTarget"></param>
		/// <returns></returns>
		public iTweenMoveTo LookTarget(Transform lookTarget) {
			return AddArgument<iTweenMoveTo>( "looktarget", lookTarget );
		}

		/// <summary>
		/// For a target the GameObject will look at.
		/// </summary>
		/// <param name="lookTarget"></param>
		/// <returns></returns>
		public iTweenMoveTo LookTarget(Vector3 lookTarget) {
			return AddArgument<iTweenMoveTo>( "looktarget", lookTarget );
		}

		/// <summary>
		/// For the time in seconds the object will take to look at either
		/// the "looktarget" or "orienttopath".
		/// </summary>
		/// <param name="lookTime"></param>
		/// <returns></returns>
		public iTweenMoveTo LookTime(float lookTime) {
			return AddArgument<iTweenMoveTo>( "looktime", lookTime );
		}

		/// <summary>
		/// For how much of a percentage (from 0 to 1) to look ahead on a path to
		/// influence how strict "orienttopath" is and how much the object will
		/// anticipate each curve.
		/// </summary>
		/// <param name="lookAhead"></param>
		/// <returns></returns>
		public iTweenMoveTo LookAhead(float lookAhead) {
			return AddArgument<iTweenMoveTo>( "lookahead", lookAhead );
		}

		/// <summary>
		/// Restricts rotation to the supplied axis only.
		/// </summary>
		/// <param name="axis"></param>
		/// <returns></returns>
		public iTweenMoveTo Axis(string axis) {
			return AddArgument<iTweenMoveTo>( "axis", axis );
		}

		/// <summary>
		/// For whether to animate in world space or relative to the parent.
		/// False be default.
		/// </summary>
		/// <param name="isLocal"></param>
		/// <returns></returns>
		public iTweenMoveTo IsLocal(bool isLocal) {
			return AddArgument<iTweenMoveTo>( "islocal", isLocal );
		}

		/// <summary>
		/// Can be used instead of time to allow animation based on speed.
		/// </summary>
		/// <param name="speed"></param>
		/// <returns></returns>
		public iTweenMoveTo Speed(float speed) {
			return AddArgument<iTweenMoveTo>( "speed", speed );
		}

	}

	/// <summary>
	/// Applies a jolt of force to a GameObject's position and wobbles it
	/// back to its initial position.
	/// </summary>
	public class iTweenPunchPosition : iTweenFluent {

		public static iTweenPunchPosition Create(GameObject target) {
			return new iTweenPunchPosition( target );
		}

		public iTweenPunchPosition(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.PunchPosition( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For a point in space the GameObject will animate to.
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public iTweenPunchPosition Amount(Vector3 amount) {
			return AddArgument<iTweenPunchPosition>( "amount", amount );
		}

		/// <summary>
		/// for the individual setting of the x axis
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public iTweenPunchPosition X(float x) {
			return AddArgument<iTweenPunchPosition>( "x", x );
		}

		/// <summary>
		/// for the individual setting of the y axis
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		public iTweenPunchPosition Y(float y) {
			return AddArgument<iTweenPunchPosition>( "y", y );
		}

		/// <summary>
		/// for the individual setting of the z axis
		/// </summary>
		/// <param name="z"></param>
		/// <returns></returns>
		public iTweenPunchPosition Z(float z) {
			return AddArgument<iTweenPunchPosition>( "z", z );
		}

		/// <summary>
		/// For applying the transformation in either the world coordinate
		/// or local cordinate system. Defaults to local space.
		/// </summary>
		/// <param name="space"></param>
		/// <returns></returns>
		public iTweenPunchPosition Space(Space space) {
			return AddArgument<iTweenPunchPosition>( "space", space );
		}

		/// <summary>
		/// For a target the GameObject will look at.
		/// </summary>
		/// <param name="lookTarget"></param>
		/// <returns></returns>
		public iTweenPunchPosition LookTarget(Transform lookTarget) {
			return AddArgument<iTweenPunchPosition>( "looktarget", lookTarget );
		}

		/// <summary>
		/// For a target the GameObject will look at.
		/// </summary>
		/// <param name="lookTarget"></param>
		/// <returns></returns>
		public iTweenPunchPosition LookTarget(Vector3 lookTarget) {
			return AddArgument<iTweenPunchPosition>( "looktarget", lookTarget );
		}

		/// <summary>
		/// For the time in seconds the object will take to look at
		/// either the "looktarget" or "orienttopath".
		/// </summary>
		/// <param name="lookTime"></param>
		/// <returns></returns>
		public iTweenPunchPosition LookTime(float lookTime) {
			return AddArgument<iTweenPunchPosition>( "looktime", lookTime );
		}

		/// <summary>
		/// Restricts rotation to the supplied axis only.
		/// </summary>
		/// <param name="axis"></param>
		/// <returns></returns>
		public iTweenPunchPosition Axis(string axis) {
			return AddArgument<iTweenPunchPosition>( "axis", axis );
		}

	}

	/// <summary>
	/// Randomly shakes a GameObject's position by a diminishing amount over time.
	/// </summary>
	public class iTweenShakePosition : iTweenFluent {

		public static iTweenShakePosition Create(GameObject target) {
			return new iTweenShakePosition( target );
		}

		public iTweenShakePosition(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.ShakePosition( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For the magnitude of shake.
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public iTweenShakePosition Amount(Vector3 amount) {
			return AddArgument<iTweenShakePosition>( "amount", amount );
		}

		/// <summary>
		/// for the individual setting of the x axis
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public iTweenShakePosition X(float x) {
			return AddArgument<iTweenShakePosition>( "x", x );
		}

		/// <summary>
		/// for the individual setting of the y axis
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		public iTweenShakePosition Y(float y) {
			return AddArgument<iTweenShakePosition>( "y", y );
		}

		/// <summary>
		/// for the individual setting of the z axis
		/// </summary>
		/// <param name="z"></param>
		/// <returns></returns>
		public iTweenShakePosition Z(float z) {
			return AddArgument<iTweenShakePosition>( "z", z );
		}

		/// <summary>
		/// For whether to animate in world space or relative to the parent.
		/// False by default.
		/// </summary>
		/// <param name="isLocal"></param>
		/// <returns></returns>
		public iTweenShakePosition IsLocal(bool isLocal) {
			return AddArgument<iTweenShakePosition>( "islocal", isLocal );
		}

		/// <summary>
		/// For whether or not the GameObject will orient to its direction of travel.
		/// False by default.
		/// </summary>
		/// <param name="orientToPath"></param>
		/// <returns></returns>
		public iTweenShakePosition OrientToPath(bool orientToPath) {
			return AddArgument<iTweenShakePosition>( "orienttopath", orientToPath );
		}

		/// <summary>
		/// For a target the GameObject will look at.
		/// </summary>
		/// <param name="lookTarget"></param>
		/// <returns></returns>
		public iTweenShakePosition LookTarget(Transform lookTarget) {
			return AddArgument<iTweenShakePosition>( "looktarget", lookTarget );
		}

		/// <summary>
		/// For a target the GameObject will look at.
		/// </summary>
		/// <param name="lookTarget"></param>
		/// <returns></returns>
		public iTweenShakePosition LookTarget(Vector3 lookTarget) {
			return AddArgument<iTweenShakePosition>( "looktarget", lookTarget );
		}

		/// <summary>
		/// For the time in seconds the object will take to look at either
		/// the "looktarget" or "orienttopath".
		/// </summary>
		/// <param name="lookTime"></param>
		/// <returns></returns>
		public iTweenShakePosition LookTime(float lookTime) {
			return AddArgument<iTweenShakePosition>( "looktime", lookTime );
		}

		/// <summary>
		/// Restricts rotation to the supplied axis only.
		/// </summary>
		/// <param name="axis"></param>
		/// <returns></returns>
		public iTweenShakePosition Axis(string axis) {
			return AddArgument<iTweenShakePosition>( "axis", axis );
		}

	}

	/// <summary>
	/// Similar to MoveTo but incredibly less expensive for usage inside the
	/// Update function or similar looping situations involving a "live" set
	/// of changing values. Does not utilize an EaseType. 
	/// </summary>
	public class iTweenMoveUpdate {
		private GameObject target;

		private Dictionary<string, object> arguments = new Dictionary<string, object>();

		public static iTweenMoveUpdate Create(GameObject target) {
			return new iTweenMoveUpdate( target );
		}

		public iTweenMoveUpdate(GameObject target) {
			this.target = target;
		}

		public void Launch() {
			iTween.MoveUpdate( target, new System.Collections.Hashtable( arguments ) );
		}

		/// <summary>
		/// For a point in space the GameObject will animate to.
		/// </summary>
		/// <param name="position"></param>
		/// <returns></returns>
		public iTweenMoveUpdate Position(Transform position) {
			return AddArgument( "position", position );
		}

		/// <summary>
		/// For a point in space the GameObject will animate to.
		/// </summary>
		/// <param name="position"></param>
		/// <returns></returns>
		public iTweenMoveUpdate Position(Vector3 position) {
			return AddArgument( "position", position );
		}

		/// <summary>
		/// for the individual setting of the x axis
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public iTweenMoveUpdate X(float x) {
			return AddArgument( "x", x );
		}

		/// <summary>
		/// for the individual setting of the y axis
		/// </summary>
		/// <param name="y"></param>
		/// <returns></returns>
		public iTweenMoveUpdate Y(float y) {
			return AddArgument( "y", y );
		}

		/// <summary>
		/// for the individual setting of the z axis
		/// </summary>
		/// <param name="z"></param>
		/// <returns></returns>
		public iTweenMoveUpdate Z(float z) {
			return AddArgument( "z", z );
		}

		/// <summary>
		/// For whether or not the GameObject will orient to its direction of travel.
		/// False by default.
		/// </summary>
		/// <param name="orientToPath"></param>
		/// <returns></returns>
		public iTweenMoveUpdate OrientToPath(bool orientToPath) {
			return AddArgument( "orienttopath", orientToPath );
		}

		/// <summary>
		/// For a target the GameObject will look at.
		/// </summary>
		/// <param name="lookTarget"></param>
		/// <returns></returns>
		public iTweenMoveUpdate LookTarget(Transform lookTarget) {
			return AddArgument( "looktarget", lookTarget );
		}

		/// <summary>
		/// For a target the GameObject will look at.
		/// </summary>
		/// <param name="lookTarget"></param>
		/// <returns></returns>
		public iTweenMoveUpdate LookTarget(Vector3 lookTarget) {
			return AddArgument( "looktarget", lookTarget );
		}

		/// <summary>
		/// For the time in seconds the object will take to look at either
		/// the "looktarget" or "orienttopath".
		/// </summary>
		/// <param name="lookTime"></param>
		/// <returns></returns>
		public iTweenMoveUpdate LookTime(float lookTime) {
			return AddArgument( "looktime", lookTime );
		}

		/// <summary>
		/// Restricts rotation to the supplied axis only.
		/// </summary>
		/// <param name="axis"></param>
		/// <returns></returns>
		public iTweenMoveUpdate Axis(string axis) {
			return AddArgument( "axis", axis );
		}

		/// <summary>
		/// For whether to animate in world space or relative to the parent.
		/// False be default.
		/// </summary>
		/// <param name="isLocal"></param>
		/// <returns></returns>
		public iTweenMoveUpdate IsLocal(bool isLocal) {
			return AddArgument( "islocal", isLocal );
		}

		/// <summary>
		/// For the time in seconds the animation will take to complete.
		/// </summary>
		/// <param name="time"></param>
		/// <returns></returns>
		public iTweenMoveUpdate Time(float time) {
			return AddArgument( "time", time );
		}

		protected iTweenMoveUpdate AddArgument(string arg, object value) {
			arguments[arg] = value;

			return this;
		}
	}

}
