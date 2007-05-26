/*
 * Created by: Mo Khan
 * Created: Saturday, May 26, 2007
 */
using System;

namespace Sait.Cmpp297.Assignment1.AsterikPatterns {
	internal class Program {
		#region Public Methods

		public static void Main( ) {
			OutputAC( delegate( Int32 xAxis, Int32 i ) { return ( xAxis < i + 1 ); } );

			OutputBD( delegate( Int32 xAxis, Int32 i ) { return ( xAxis < i ); } );

			OutputAC( delegate( Int32 xAxis, Int32 i ) { return ( xAxis >= i ); } );

			OutputBD( delegate( Int32 xAxis, Int32 i ) { return ( i <= xAxis + 1 ); } );
			Console.ReadLine( );
		}

		#endregion

		#region Private Fields

		private delegate Boolean CheckCondition( Int32 xAxis, Int32 charactersPerRow );

		#endregion

		#region Private Methods

		private static void OutputAC( CheckCondition condition ) {
			Int32 charactersPerRow = 0;
			// loop through the y axis from row 0 to 10
			for ( int yAxis = 0; yAxis < 10; yAxis++ ) {
				// loop through x axis from column 0 to 10 for each row.
				for ( int xAxis = 0; xAxis < 10; xAxis++ ) {
					// write the character for the current position
					Console.Write( condition( xAxis, charactersPerRow ) ? "*" : " " );
				}
				++charactersPerRow;
				Console.WriteLine( );
			}
		}

		private static void OutputBD( CheckCondition condition ) {
			Int32 charactersPerRow = 10;
			for ( int yAxis = 0; yAxis < 10; yAxis++ ) {
				for ( int xAxis = 0; xAxis < 10; xAxis++ ) {
					Console.Write( condition( xAxis, charactersPerRow ) ? "*" : " " );
				}
				--charactersPerRow;
				Console.WriteLine( );
			}
		}

		#endregion
	}
}