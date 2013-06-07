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
	/// Instantly changes an AudioSource's volume and pitch then returns it to
	/// it's starting volume and pitch over time.
	/// Default AudioSource attached to GameObject will be used
	/// (if one exists) if not supplied.
	/// </summary>
	public class iTweenAudioFrom : iTweenFluent {

		public static iTweenAudioFrom Create(GameObject target) {
			return new iTweenAudioFrom( target );
		}

		public iTweenAudioFrom(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.AudioFrom( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For which AudioSource to use.
		/// </summary>
		/// <param name="audioSource"></param>
		/// <returns></returns>
		public iTweenAudioFrom AudioSource(AudioSource audioSource) {
			return AddArgument<iTweenAudioFrom>( "audiosource", audioSource );
		}

		/// <summary>
		/// For the target level of volume.
		/// </summary>
		/// <param name="volume"></param>
		/// <returns></returns>
		public iTweenAudioFrom Volume(float volume) {
			return AddArgument<iTweenAudioFrom>( "volume", volume );
		}

		/// <summary>
		/// For the target pitch.
		/// </summary>
		/// <param name="pitch"></param>
		/// <returns></returns>
		public iTweenAudioFrom Pitch(float pitch) {
			return AddArgument<iTweenAudioFrom>( "pitch", pitch );
		}

	}

	/// <summary>
	/// Fades volume and pitch of an AudioSource.
	/// Default AudioSource attached to GameObject will be used
	/// (if one exists) if not supplied.
	/// </summary>
	public class iTweenAudioTo: iTweenFluent {

		public static iTweenAudioTo Create(GameObject target) {
			return new iTweenAudioTo( target );
		}

		public iTweenAudioTo(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.AudioTo( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For which AudioSource to use.
		/// </summary>
		/// <param name="audioSource"></param>
		/// <returns></returns>
		public iTweenAudioTo AudioSource(AudioSource audioSource) {
			return AddArgument<iTweenAudioTo>( "audiosource", audioSource );
		}

		/// <summary>
		/// For the target level of volume.
		/// </summary>
		/// <param name="volume"></param>
		/// <returns></returns>
		public iTweenAudioTo Volume(float volume) {
			return AddArgument<iTweenAudioTo>( "volume", volume );
		}

		/// <summary>
		/// For the target pitch.
		/// </summary>
		/// <param name="pitch"></param>
		/// <returns></returns>
		public iTweenAudioTo Pitch(float pitch) {
			return AddArgument<iTweenAudioTo>( "pitch", pitch );
		}

	}

	/// <summary>
	/// Similar to AudioTo but incredibly less expensive for usage inside the
	/// Update function or similar looping situations involving a "live" set
	/// of changing values. Does not utilize an EaseType.
	/// </summary>
	public class iTweenAudioUpdate {
		private GameObject target;

		private Dictionary<string, object> arguments = new Dictionary<string, object>();

		public static iTweenAudioUpdate Create(GameObject target) {
			return new iTweenAudioUpdate( target );
		}

		public iTweenAudioUpdate(GameObject target) {
			this.target = target;
		}

		public void Launch() {
			iTween.AudioUpdate( target, new System.Collections.Hashtable( arguments ) );
		}

		/// <summary>
		/// For which AudioSource to use.
		/// </summary>
		/// <param name="audioSource"></param>
		/// <returns></returns>
		public iTweenAudioUpdate AudioSource(AudioSource audioSource) {
			return AddArgument( "audiosource", audioSource );
		}

		/// <summary>
		/// For the target level of volume.
		/// </summary>
		/// <param name="volume"></param>
		/// <returns></returns>
		public iTweenAudioUpdate Volume(float volume) {
			return AddArgument( "volume", volume );
		}

		/// <summary>
		/// For the target pitch.
		/// </summary>
		/// <param name="pitch"></param>
		/// <returns></returns>
		public iTweenAudioUpdate Pitch(float pitch) {
			return AddArgument( "pitch", pitch );
		}

		/// <summary>
		/// For the time in seconds the animation will take to complete.
		/// </summary>
		/// <param name="time"></param>
		/// <returns></returns>
		public iTweenAudioUpdate Time(float time) {
			return AddArgument( "time", time );
		}

		protected iTweenAudioUpdate AddArgument(string arg, object value) {
			arguments[arg] = value;

			return this;
		}
	}

	/// <summary>
	/// Plays an AudioClip once based on supplied volume and pitch and following
	/// any delay. AudioSource is optional as iTween will provide one.
	/// </summary>
	public class iTweenAudioStab {
		private GameObject target;

		private Dictionary<string, object> arguments = new Dictionary<string, object>();

		public static iTweenAudioStab Create(GameObject target) {
			return new iTweenAudioStab( target );
		}

		public iTweenAudioStab(GameObject target) {
			this.target = target;
		}

		public void Launch() {
			iTween.Stab( target, new System.Collections.Hashtable( arguments ) );
		}

		/// <summary>
		/// For a reference to the AudioClip to be played.
		/// </summary>
		/// <param name="audioClip"></param>
		/// <returns></returns>
		public iTweenAudioStab AudioClip(AudioClip audioClip) {
			return AddArgument( "audioclip", audioClip );
		}

		/// <summary>
		/// For which AudioSource to use.
		/// </summary>
		/// <param name="audioSource"></param>
		/// <returns></returns>
		public iTweenAudioStab AudioSource(AudioSource audioSource) {
			return AddArgument( "audiosource", audioSource );
		}

		/// <summary>
		/// For the target level of volume.
		/// </summary>
		/// <param name="volume"></param>
		/// <returns></returns>
		public iTweenAudioStab Volume(float volume) {
			return AddArgument( "volume", volume );
		}

		/// <summary>
		/// For the target pitch.
		/// </summary>
		/// <param name="pitch"></param>
		/// <returns></returns>
		public iTweenAudioStab Pitch(float pitch) {
			return AddArgument( "pitch", pitch );
		}

		/// <summary>
		/// For the time in seconds the action will wait before beginning.
		/// </summary>
		/// <param name="delay"></param>
		/// <returns></returns>
		public iTweenAudioStab Delay(float delay) {
			return AddArgument( "delay", delay );
		}

		/// <summary>
		/// For the name of a function to launch at the beginning of the animation.
		/// </summary>
		/// <param name="functionName"></param>
		/// <returns></returns>
		public iTweenAudioStab OnStart(string functionName) {
			return AddArgument( "onstart", functionName );
		}

		/// <summary>
		/// For a reference to the GameObject that holds the "onstart" method.
		/// </summary>
		/// <param name="target"></param>
		/// <returns></returns>
		public iTweenAudioStab OnStartTarget(object target) {
			return AddArgument( "onstarttarget", target );
		}

		/// <summary>
		/// For arguments to be sent to the "onstart" method.
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		public iTweenAudioStab OnStartParams(object parameters) {
			return AddArgument( "onstartparams", parameters );
		}

		/// <summary>
		/// For the name of a function to launch on every step of the animation.
		/// </summary>
		/// <param name="functionName"></param>
		/// <returns></returns>
		public iTweenAudioStab OnUpdate(string functionName) {
			return AddArgument( "onupdate", functionName );
		}

		/// <summary>
		/// For a reference to the GameObject that holds the "onupdate" method.
		/// </summary>
		/// <param name="target"></param>
		/// <returns></returns>
		public iTweenAudioStab OnUpdateTarget(object target) {
			return AddArgument( "onupdatetarget", target );
		}

		/// <summary>
		/// For arguments to be sent to the "onupdate" method.
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		public iTweenAudioStab OnUpdateParams(object parameters) {
			return AddArgument( "onupdateparams", parameters );
		}

		/// <summary>
		/// For the name of a function to launch at the end of the animation.
		/// </summary>
		/// <param name="functionName"></param>
		/// <returns></returns>
		public iTweenAudioStab OnComplete(string functionName) {
			return AddArgument( "oncomplete", functionName );
		}

		/// <summary>
		/// For a reference to the GameObject that holds the "oncomplete" method.
		/// </summary>
		/// <param name="target"></param>
		/// <returns></returns>
		public iTweenAudioStab OnCompleteTarget(object target) {
			return AddArgument( "oncompletetarget", target );
		}

		/// <summary>
		/// For arguments to be sent to the "oncomplete" method.
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		public iTweenAudioStab OnCompleteParams(object parameters) {
			return AddArgument( "oncompleteparams", parameters );
		}

		protected iTweenAudioStab AddArgument(string arg, object value) {
			arguments[arg] = value;

			return this;
		}
	}

}
