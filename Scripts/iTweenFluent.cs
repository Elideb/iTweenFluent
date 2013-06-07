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
	/// Base class for the fluent implementation. Includes the common cases.
	/// The methods from this class should be called at the end,
	/// or the result cast back to the desired class.
	/// </summary>
	public abstract class iTweenFluent {
		private GameObject target;

		/// <summary>
		/// Which game object the tween will be applied on.
		/// </summary>
		public GameObject Target {
			get { return target; }
			set { target = value; }
		}

		private Dictionary<string, object> arguments = new Dictionary<string, object>();

		protected Dictionary<string, object> Arguments { get { return arguments; } }

		protected iTweenFluent(GameObject target) {
			this.target = target;
		}

		abstract public void Launch();

		/// <summary>
		/// Change the target set for the tween.
		/// Useful to apply the same tween on several elements.
		/// </summary>
		/// <param name="target"></param>
		/// <returns></returns>
		public iTweenFluent SetTarget(GameObject target) {
			Target = target;

			return this;
		}

		/// <summary>
		/// An individual name useful for stopping iTweens by name.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public iTweenFluent Name(string name) {
			return AddArgument( "name", name );
		}

		#region OnStart

		/// <summary>
		/// For the name of a function to launch at the beginning of the animation.
		/// </summary>
		/// <param name="functionName"></param>
		/// <returns></returns>
		public iTweenFluent OnStart(string functionName) {
			return AddArgument( "onstart", functionName );
		}

		/// <summary>
		/// For a reference to the GameObject that holds the "onstart" method.
		/// </summary>
		/// <param name="target"></param>
		/// <returns></returns>
		public iTweenFluent OnStartTarget(object target) {
			return AddArgument( "onstarttarget", target );
		}

		/// <summary>
		/// For arguments to be sent to the "onstart" method.
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		public iTweenFluent OnStartParams(object parameters) {
			return AddArgument( "onstartparams", parameters );
		}

		#endregion

		#region OnUpdate

		/// <summary>
		/// For the name of a function to launch on every step of the animation.
		/// </summary>
		/// <param name="functionName"></param>
		/// <returns></returns>
		public iTweenFluent OnUpdate(string functionName) {
			return AddArgument( "onupdate", functionName );
		}

		/// <summary>
		/// For a reference to the GameObject that holds the "onupdate" method.
		/// </summary>
		/// <param name="target"></param>
		/// <returns></returns>
		public iTweenFluent OnUpdateTarget(object target) {
			return AddArgument( "onupdatetarget", target );
		}

		/// <summary>
		/// For arguments to be sent to the "onupdate" method.
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		public iTweenFluent OnUpdateParams(object parameters) {
			return AddArgument( "onupdateparams", parameters );
		}

		#endregion

		#region OnComplete

		/// <summary>
		/// For the name of a function to launch at the end of the animation.
		/// </summary>
		/// <param name="functionName"></param>
		/// <returns></returns>
		public iTweenFluent OnComplete(string functionName) {
			return AddArgument( "oncomplete", functionName );
		}

		/// <summary>
		/// For a reference to the GameObject that holds the "oncomplete" method.
		/// </summary>
		/// <param name="target"></param>
		/// <returns></returns>
		public iTweenFluent OnCompleteTarget(object target) {
			return AddArgument( "oncompletetarget", target );
		}

		/// <summary>
		/// For arguments to be sent to the "oncomplete" method.
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		public iTweenFluent OnCompleteParams(object parameters) {
			return AddArgument( "oncompleteparams", parameters );
		}

		#endregion

		/// <summary>
		/// Setting this to true will allow the animation to continue independent
		/// of the current time which is helpful for animating menus after a game
		/// has been paused by setting Time.timeScale=0.
		/// </summary>
		/// <param name="ignoreTimeScale"></param>
		/// <returns></returns>
		public iTweenFluent IgnoreTimeScale(bool ignoreTimeScale) {
			return AddArgument( "ignoretimescale", ignoreTimeScale );
		}

		/// <summary>
		/// For the time in seconds the animation will take to complete.
		/// </summary>
		/// <param name="time"></param>
		/// <returns></returns>
		public iTweenFluent Time(float time) {
			return AddArgument( "time", time );
		}

		/// <summary>
		/// For the time in seconds the action will wait before beginning.
		/// </summary>
		/// <param name="delay"></param>
		/// <returns></returns>
		public iTweenFluent Delay(float delay) {
			return AddArgument( "delay", delay );
		}

		/// <summary>
		/// For the shape of the easing curve applied to the animation.
		/// </summary>
		/// <param name="easeType"></param>
		/// <returns></returns>
		public iTweenFluent EaseType(iTween.EaseType easeType) {
			return AddArgument( "easetype", easeType );
		}

		/// <summary>
		/// For the type of loop to apply once the animation has completed.
		/// Not supported by iTweenValueTo.
		/// </summary>
		/// <param name="loopType"></param>
		/// <returns></returns>
		public iTweenFluent LoopType(iTween.LoopType loopType) {
			return AddArgument( "looptype", loopType );
		}

		protected iTweenFluent AddArgument(string arg, object value) {
			arguments[arg] = value;

			return this;
		}

		protected T AddArgument<T>(string arg, object value) where T : iTweenFluent {
			arguments[arg] = value;

			return this as T;
		}
	}

}
