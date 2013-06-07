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
	/// Returns a value to a callback method interpolated between the supplied
	/// 'from' and 'to' values for application as desired. Requires an 'onupdate'
	/// callback that accepts the same type as the supplied 'from' and 'to'
	/// properties.
	/// </summary>
	public class iTweenValueTo : iTweenFluent {

		public static iTweenValueTo Create(GameObject target) {
			return new iTweenValueTo( target );
		}

		public iTweenValueTo(GameObject target)
			: base( target ) {
		}

		public override void Launch() {
			iTween.ValueTo( Target, new System.Collections.Hashtable( Arguments ) );
		}

		/// <summary>
		/// For the starting value.
		/// </summary>
		/// <param name="from"></param>
		/// <returns></returns>
		public iTweenValueTo From(float from) {
			return AddArgument<iTweenValueTo>( "from", from );
		}

		/// <summary>
		/// For the starting value.
		/// </summary>
		/// <param name="from"></param>
		/// <returns></returns>
		public iTweenValueTo From(Vector3 from) {
			return AddArgument<iTweenValueTo>( "from", from );
		}

		/// <summary>
		/// For the starting value.
		/// </summary>
		/// <param name="from"></param>
		/// <returns></returns>
		public iTweenValueTo From(Vector2 from) {
			return AddArgument<iTweenValueTo>( "from", from );
		}

		/// <summary>
		/// For the starting value.
		/// </summary>
		/// <param name="from"></param>
		/// <returns></returns>
		public iTweenValueTo From(Color from) {
			return AddArgument<iTweenValueTo>( "from", from );
		}

		/// <summary>
		/// For the starting value.
		/// </summary>
		/// <param name="from"></param>
		/// <returns></returns>
		public iTweenValueTo From(Rect from) {
			return AddArgument<iTweenValueTo>( "from", from );
		}

		/// <summary>
		/// For the ending value.
		/// </summary>
		/// <param name="from"></param>
		/// <returns></returns>
		public iTweenValueTo To(float to) {
			return AddArgument<iTweenValueTo>( "to", to );
		}

		/// <summary>
		/// For the ending value.
		/// </summary>
		/// <param name="from"></param>
		/// <returns></returns>
		public iTweenValueTo To(Vector3 to) {
			return AddArgument<iTweenValueTo>( "to", to );
		}

		/// <summary>
		/// For the ending value.
		/// </summary>
		/// <param name="from"></param>
		/// <returns></returns>
		public iTweenValueTo To(Vector2 to) {
			return AddArgument<iTweenValueTo>( "to", to );
		}

		/// <summary>
		/// For the ending value.
		/// </summary>
		/// <param name="from"></param>
		/// <returns></returns>
		public iTweenValueTo To(Color to) {
			return AddArgument<iTweenValueTo>( "to", to );
		}

		/// <summary>
		/// For the ending value.
		/// </summary>
		/// <param name="from"></param>
		/// <returns></returns>
		public iTweenValueTo To(Rect to) {
			return AddArgument<iTweenValueTo>( "to", to );
		}

		/// <summary>
		/// Can be used instead of time to allow animation based on speed.
		/// Only works with Vector2, Vector3, and Floats.
		/// </summary>
		/// <param name="speed"></param>
		/// <returns></returns>
		public iTweenValueTo Speed(float speed) {
			return AddArgument<iTweenValueTo>( "time", speed );
		}

	}

}
