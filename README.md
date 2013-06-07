iTweenFluent
============

A set of wrapper classes to manage [iTween](http://code.google.com/p/itween/) using fluent interfaces in Unity.

Example
-------

using iTweenFluent:

    using System.Collections;
    using iTweenFluent;
    using UnityEngine;

    public class TweenTests : MonoBehaviour {

        // Use this for initialization
        void Start () {
            iTween.CameraFadeAdd();
        }

        // Update is called once per frame
        void Update () {
            if (Input.GetKeyDown( KeyCode.Q )) {
                iTweenCameraFadeFrom.Create()
                    .Amount( .5f )
                    .EaseType( iTween.EaseType.easeInOutBack )
                    .LoopType( iTween.LoopType.pingPong )
                    .Name( "CameraFade" )
                    .Launch();
            }

            if (Input.GetKeyDown( KeyCode.W )) {
                iTweenColorTo.Create( gameObject )
                    .Color( Color.cyan )
                    .NamedColorValue( "_Color" )
                    .Time( 2 )
                    .OnComplete( "color2" )
                    .OnCompleteTarget( this.gameObject )
                    .Launch();
            }

            if (Input.GetKeyDown( KeyCode.E )) {
                iTweenFadeTo.Create( gameObject )
                    .Alpha( 1 )
                    .Amount( 0 )
                    .Delay( .5f )
                    .Time( 1 )
                    .Launch();
            }

            if (Input.GetKeyDown( KeyCode.R )) {
                iTweenFadeTo.Create( gameObject )
                    .Amount( 1 )
                    .Time( 1 )
                    .Launch();
            }

            if (Input.GetKeyDown( KeyCode.T )) {
                iTweenMoveBy.Create( gameObject )
                    .Amount( new Vector3( 1, 2, 4 ) )
                    .Axis( "x" )
                    .Speed( 1 )
                    .LoopType( iTween.LoopType.pingPong )
                    .Launch();
            }

        }

        private void color2() {
            iTweenColorTo.Create( gameObject )
                .Color( Color.green )
                .Time( 1 )
                .OnComplete( "color3" )
                .OnCompleteTarget( gameObject )
                .Launch();

        }

        private void color3() {
            iTweenColorFrom.Create( gameObject )
                .Color( Color.red )
                .Time( 1 )
                .Launch();
        }
    }

Compared to using iTween:

    using System.Collections;
    using UnityEngine;

    public class TweenTests : MonoBehaviour {

        // Use this for initialization
        void Start () {
            iTween.CameraFadeAdd();
        }

        // Update is called once per frame
        void Update () {
            if (Input.GetKeyDown( KeyCode.Q )) {
                iTween.CameraFadeFrom(
                    new Hashtable() {
                        { "amount", .5f },
                        { "easetype", iTween.EaseType.easeInOutBack },
                        { "looptype", iTween.LoopType.pingPong },
                        { "name", "CameraFade" }
                    } );
            }

            if (Input.GetKeyDown( KeyCode.W )) {
                iTween.ColorTo(
                    gameObject,
                    new Hashtable() {
                        { "color", Color.cyan },
                        { "NamedColorValue", "_Color" },
                        { "time", 2 },
                        { "oncomplete", "color2" },
                        { "oncompletetarget", this.gameObject }
                    } );
            }

            if (Input.GetKeyDown( KeyCode.E )) {
                iTween.FadeTo(
                    gameObject,
                    new Hashtable() {
                        { "alpha", 1 },
                        { "amount", 0 },
                        { "delay", .5f },
                        { "time", 1 }
                    } );
            }

            if (Input.GetKeyDown( KeyCode.R )) {
                iTween.FadeTo(
                    gameObject,
                    new Hashtable() {
                        { "amount",  1 },
                        { "time", 1 }
                    } );
            }

            if (Input.GetKeyDown( KeyCode.T )) {
                iTween.MoveBy(
                    gameObject,
                    new Hashtable() {
                        { "amount", new Vector3( 1, 2, 4 ) },
                        { "axis", "x" },
                        { "speed", 1 },
                        { "looptype", iTween.LoopType.pingPong }
                    } );
            }

        }

        private void color2() {
            iTween.ColorTo(
                gameObject,
                new Hashtable() {
                    { "color", Color.green },
                    { "time",  1 },
                    { "oncomplete", "color3" },
                    { "oncompletetarget", gameObject }
                } );

        }

        private void color3() {
            iTween.ColorFrom(
                gameObject,
                new Hashtable() {
                    { "color", Color.red },
                    { "time", 1 }
                } );
        }
    }

License
-------
This project is released under the MIT License. Check the LICENSE file included
with the project, or each individual file for details.

Basically, you are free to do as you please, except change the license.
