iTweenFluent
============

A set of wrapper classes to manage [iTween](http://code.google.com/p/itween/) using fluent interfaces in Unity.

Example
-------

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
                // Fluent usage:
                iTweenCameraFadeFrom.Create()
                    .Amount( .5f )
                    .EaseType( iTween.EaseType.easeInOutBack )
                    .LoopType( iTween.LoopType.pingPong )
                    .Name( "CameraFade" )
                    .Launch();

                // iTween syntax:
                iTween.CameraFadeFrom(
                    new Hashtable() {
                        { "amount", .5f },
                        { "easetype", iTween.EaseType.easeInOutBack },
                        { "looptype", iTween.LoopType.pingPong },
                        { "name", "CameraFade" }
                    } );
            }

            if (Input.GetKeyDown( KeyCode.W )) {
                // Fluent usage:
                iTweenColorTo.Create( gameObject )
                    .Color( Color.cyan )
                    .NamedColorValue( "_Color" )
                    .Time( 2 )
                    .OnComplete( "color2" )
                    .OnCompleteTarget( this.gameObject )
                    .Launch();

                // iTween syntax:
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
                // Fluent usage:
                iTweenFadeTo.Create( gameObject )
                    .Alpha( 1 )
                    .Amount( 0 )
                    .Delay( .5f )
                    .Time( 1 )
                    .Launch();

                // iTween syntax:
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
                // Fluent usage:
                iTweenFadeTo.Create( gameObject )
                    .Amount( 1 )
                    .Time( 1 )
                    .Launch();

                // iTween syntax:
                iTween.FadeTo(
                    gameObject,
                    new Hashtable() {
                        { "amount",  1 },
                        { "time", 1 }
                    } );
            }

            if (Input.GetKeyDown( KeyCode.T )) {
                // Fluent usage:
                iTweenMoveBy.Create( gameObject )
                    .Amount( new Vector3( 1, 2, 4 ) )
                    .Axis( "x" )
                    .Speed( 1 )
                    .LoopType( iTween.LoopType.pingPong )
                    .Launch();

                // iTween syntax:
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
            // Fluent usage:
            iTweenColorTo.Create( gameObject )
                .Color( Color.green )
                .Time( 1 )
                .OnComplete( "color3" )
                .OnCompleteTarget( gameObject )
                .Launch();

            // iTween syntax:
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
            // Fluent usage:
            iTweenColorFrom.Create( gameObject )
                .Color( Color.red )
                .Time( 1 )
                .Launch();

            // iTween syntax:
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
